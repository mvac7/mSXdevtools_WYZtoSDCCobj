Imports System.IO
Imports System.Xml
Imports System.Windows.Forms


Public Class WYZtoSDCCobj

    Private Const TrackerName As String = "WYZ Tracker"

    Private Const DataByteInst = ".DB"
    Private Const DataWordInst = ".DW"

    Private Const SONG_LABEL = "SONG"

    Private _txtPath As String



    Private SongName As String
    Private SongAuthor As String


    Private WYZ_Path As String


    Private WYZ_instruments_Index As String
    'Private WYZ_instruments_Comments As ArrayList
    Private WYZ_instruments As ArrayList

    Private WYZ_FXs_Index As String
    'Private WYZ_FXs_Comments As ArrayList
    Private WYZ_FXs As ArrayList

    Private WYZ_SongsData As New Hashtable


    Private WYZ_DATOS_NOTAS(61) As Object 'New ArrayList




    Private Sub WYZtoCdataWin_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetTitle("")

        Me.MUS_ListBox.Items.Clear()

        GenerateData()

    End Sub



    Private Sub SetTitle(ByVal filename As String)

        Dim debuging As String = ""

        If Not filename = "" Then
            filename = " · [" + filename + "]"
        End If

        'If Me.TEST_MODE Then
        '    debuging = " > DEBUG MODE <"
        'End If

        Me.Text = My.Application.Info.Title + " v" + My.Application.Info.Version.ToString + filename
    End Sub



    Private Sub AddAsmButton_Click(sender As Object, e As EventArgs) Handles AddAsmButton.Click
        LoadInstrumentsData_Dialog()
    End Sub



    Private Sub AddMUS_Button_Click(sender As Object, e As EventArgs) Handles AddMUS_Button.Click
        AddSongData_Dialog()
    End Sub


    Private Sub DeleteMUS_Button_Click(sender As Object, e As EventArgs) Handles DeleteMUS_Button.Click
        Dim itemName As String
        If Me.MUS_ListBox.SelectedIndex >= 0 Then
            itemName = CStr(Me.MUS_ListBox.SelectedItem)
            Me.MUS_ListBox.Items.RemoveAt(Me.MUS_ListBox.SelectedIndex)
            Me.WYZ_SongsData.Remove(itemName)
            GenerateData()
        End If
    End Sub



    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        'Dim aValue As Byte = 6
        'Dim tmpResult As String = Convert.ToString(aValue, 2).PadLeft(8, "0"c)

        Me.MUS_ListBox.Items.Clear()
        Me.WYZ_SongsData.Clear()
        GenerateData()
    End Sub



    Private Sub AddSongData_Dialog()

        Me.OpenFileDialog1.Multiselect = True

        If Me.WYZ_Path = "" Then
            'Me.OpenFileDialog1.FileName = ""
            Me.OpenFileDialog1.InitialDirectory = Application.StartupPath
        Else
            '    Me.OpenFileDialog1.FileName = Path.GetFileName(Me.filePath)
            Me.OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(Me.WYZ_Path)
        End If

        'Me.OpenFileDialog1.DefaultExt = "prj"
        Me.OpenFileDialog1.Filter = "WYZ Song Sequence Data|*.mus"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            For i As Integer = 0 To OpenFileDialog1.FileNames.Length - 1
                AddSongData(OpenFileDialog1.FileNames(i))
            Next

        End If

    End Sub



    Private Sub AddSongData(ByVal filePath As String)

        Dim aFileData As Object()

        aFileData = LoadBinary(filePath)

        If Not aFileData Is Nothing Then
            Me.MUS_ListBox.Items.Add(Path.GetFileName(filePath))
            Me.WYZ_SongsData.Add(Path.GetFileName(filePath), aFileData)

            GenerateData()
        End If

    End Sub



    Private Sub LoadInstrumentsData_Dialog()

        Me.OpenFileDialog1.Multiselect = False

        If Me.WYZ_Path = "" Then
            'Me.OpenFileDialog1.FileName = ""
            Me.OpenFileDialog1.InitialDirectory = Application.StartupPath
        Else
            '    Me.OpenFileDialog1.FileName = Path.GetFileName(Me.filePath)
            Me.OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(Me.WYZ_Path)
        End If

        'Me.OpenFileDialog1.DefaultExt = "prj"
        Me.OpenFileDialog1.Filter = "WYZ Instruments Data|*.mus.asm"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.MUSasm_TextBox.Text = Path.GetFileName(OpenFileDialog1.FileName)
            LoadInstrumentsData(OpenFileDialog1.FileName)
        End If
    End Sub



    Private Sub LoadInstrumentsData(ByVal filePath As String)

        Dim i As Integer
        Dim o As Integer
        Dim aItem As String
        Dim dataText As ArrayList
        Dim tmpString As String

        Dim instrument As WYZ_Instrument
        Dim effect As WYZ_Instrument

        Dim splitItems() As String

        Dim tempNotas As New ArrayList


        Dim separators As Char() = {"'"c, " "c}
        'Dim values_separators As Char() = {","c}

        Me.WYZ_Path = filePath
        SetTitle(Path.GetFileName(filePath))

        dataText = LoadTextFile(filePath)

        WYZ_instruments = New ArrayList
        WYZ_FXs = New ArrayList


        For Each aItem In dataText
            If aItem.Contains("TABLA_PAUTAS:") Then
                WYZ_instruments_Index = aItem.Substring(aItem.IndexOf("DW") + 2).Trim
                Exit For
            End If
        Next

        For i = 0 To dataText.Count - 1
            aItem = dataText.Item(i)
            If aItem.Contains(";Instrumento") Then
                instrument = New WYZ_Instrument
                splitItems = aItem.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                instrument.Name = splitItems(1)
                i += 1
                aItem = dataText.Item(i)
                instrument.Label = aItem.Substring(0, aItem.IndexOf(":"))
                instrument.Data = aItem.Substring(aItem.IndexOf("DB") + 3)
                Me.WYZ_instruments.Add(instrument)
            End If
        Next



        For Each aItem In dataText
            If aItem.Contains("TABLA_SONIDOS:") Then
                WYZ_FXs_Index = aItem.Substring(aItem.IndexOf("DW") + 2).Trim
                Exit For
            End If
        Next

        For i = 0 To dataText.Count - 1
            aItem = dataText.Item(i)
            If Not aItem.Contains(";Efectos") Then
                If aItem.Contains(";Efecto") Then
                    effect = New WYZ_Instrument
                    splitItems = aItem.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    effect.Name = splitItems(1)
                    i += 1
                    aItem = dataText.Item(i)
                    effect.Label = aItem.Substring(0, aItem.IndexOf(":"))
                    effect.Data = aItem.Substring(aItem.IndexOf("DB") + 3)
                    Me.WYZ_FXs.Add(effect)
                End If
            End If
        Next


        ' tabla de notas <<---------------------------------------
        For i = 0 To dataText.Count - 1
            aItem = dataText.Item(i)
            'DATOS_NOTAS: DW 0,0
            If aItem.Contains("DATOS_NOTAS:") Then
                ' WYZ_DATOS_NOTAS
                tempNotas.Add(CShort(0))
                tempNotas.Add(CShort(0))
                For o = i + 1 To dataText.Count - 1
                    aItem = dataText.Item(o)
                    tmpString = aItem.Substring(aItem.IndexOf("DW") + 2).Trim
                    splitItems = tmpString.Split(","c) 'values_separators, StringSplitOptions.RemoveEmptyEntries
                    For Each value As String In splitItems
                        tempNotas.Add(CShort(value))
                    Next
                Next

                Me.WYZ_DATOS_NOTAS = tempNotas.ToArray

                Exit For
            End If

        Next


        GenerateData()

    End Sub




    Private Sub SaveAs()

        If Me.OutputText.Text = "" Then
            MsgBox("Nothing to save for you...", MsgBoxStyle.Exclamation, "Alert")
        Else

            Me.SaveFileDialog1.Filter = "SDCC Assembler file|*.s"

            If Not Me.WYZ_Path = "" Then
                Me.SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(Me.WYZ_Path)
                Me.SaveFileDialog1.FileName = Path.GetFileNameWithoutExtension(Me.WYZ_Path)
            End If

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                Me.SaveCode(SaveFileDialog1.FileName)

            End If

        End If

    End Sub



    ''' <summary>
    ''' Save source output.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Sub SaveCode(ByVal filePath As String)
        Dim aStreamWriterFile As New System.IO.StreamWriter(filePath)
        aStreamWriterFile.WriteLine(Me.OutputText.Text)
        aStreamWriterFile.Close()
    End Sub



    ''' <summary>
    ''' Load binary file.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LoadBinary(ByVal filePath As String) As Object()

        Dim aStream As FileStream
        Dim aFile As New FileInfo(filePath)

        Dim aFileData As Byte()
        Dim outputData As Object()

        Dim conta As Integer = 7

        Dim filesize As Long = aFile.Length - 1

        If filesize > 65536 Then
            Return Nothing
        End If

        aStream = New System.IO.FileStream(filePath, FileMode.Open)

        ReDim aFileData(filesize)
        ReDim outputData(filesize)

        aStream.Read(aFileData, 0, filesize)
        aStream.Close()


        ' convert Byte Array to Object Array
        For i As Integer = 0 To filesize
            outputData(i) = aFileData(i)
        Next

        Return outputData

    End Function



    Private Sub GenerateData()

        Dim aMSXDataFormat As New DataFormat

        Dim comments As New ArrayList

        Dim outputData As Object()

        Dim anItem As String

        Dim SongNumber As Integer = 0

        OutputText.Text = ";" + TrackerName + " Music and FXs Data" + vbNewLine
        OutputText.Text += ";" + My.Application.Info.ProductName + " v" + My.Application.Info.Version.ToString + vbNewLine + vbNewLine

        'If SongInfo_CheckBox.Checked Then
        '    OutputText.Text += "const char " + labelName + "_name[] = " + Chr(34) + Me.SongName + Chr(34) + ";" + vbNewLine
        '    OutputText.Text += "const char " + labelName + "_author[] = " + Chr(34) + Me.SongAuthor + Chr(34) + ";" + vbNewLine + vbNewLine
        'End If


        If Me.WYZ_SongsData.Count > 0 Then
            OutputText.Text += "; songs index" + vbNewLine
            OutputText.Text += "_WYZ_songs:: " + DataWordInst + " "
            'Me.WYZ_SongsData
            For Each anItem In Me.WYZ_SongsData.Keys
                OutputText.Text += SONG_LABEL + CStr(SongNumber).PadLeft(2, "0"c) + ","
                SongNumber += 1
            Next

            OutputText.Text = OutputText.Text.Remove(OutputText.Text.Length - 1, 1) 'erase last comma

            OutputText.Text += vbNewLine + vbNewLine
        End If



        If Not Me.WYZ_Path = "" Then

            OutputText.Text += "; Tabla de instrumentos (instruments index)" + vbNewLine
            OutputText.Text += "_WYZ_instruments:: " + DataWordInst + " " + Me.WYZ_instruments_Index + vbNewLine
            OutputText.Text += vbNewLine

            OutputText.Text += "; Tabla de efectos (FXs index)" + vbNewLine
            OutputText.Text += "_WYZ_FXs:: " + DataWordInst + " " + Me.WYZ_FXs_Index + vbNewLine
            OutputText.Text += vbNewLine

            OutputText.Text += ";Instruments" + vbNewLine
            For Each item As WYZ_Instrument In Me.WYZ_instruments
                OutputText.Text += ";Instrumento '" + item.Name + "'" + vbNewLine
                OutputText.Text += item.Label + ": " + DataByteInst + " " + item.Data + vbNewLine
            Next
            OutputText.Text += vbNewLine

            OutputText.Text += ";FXs" + vbNewLine
            For Each item As WYZ_Instrument In Me.WYZ_FXs
                OutputText.Text += ";Efecto '" + item.Name + "'" + vbNewLine
                OutputText.Text += item.Label + ": " + DataByteInst + " " + item.Data + vbNewLine
            Next
            OutputText.Text += vbNewLine


            ' tabla de notas <<---------------------------------------
            comments.Clear()
            comments.Add("Frecuencias para las notas")
            OutputText.Text += aMSXDataFormat.GetAsmCode(Me.WYZ_DATOS_NOTAS, 10, DataFormat.ByteDataFormat.HEXADECIMAL_0xnn, "_WYZ_notes:", comments, DataWordInst)
            OutputText.Text += vbNewLine

        End If


        SongNumber = 0
        If Me.WYZ_SongsData.Count > 0 Then
            For Each anItem In Me.WYZ_SongsData.Keys
                comments.Clear()
                comments.Add(anItem)

                outputData = Me.WYZ_SongsData.Item(anItem)

                comments.Add("Length: " + CStr(outputData.Length))
                OutputText.Text += aMSXDataFormat.GetAsmCode(outputData, 16, DataFormat.ByteDataFormat.HEXADECIMAL_0xnn, SONG_LABEL + CStr(SongNumber).PadLeft(2, "0"c), comments, DataByteInst)
                OutputText.Text += vbNewLine
                SongNumber += 1
            Next
        End If

    End Sub


    ''' <summary>
    ''' Copy output to clipboard
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CopyAll()
        If Me.OutputText.Text = "" Then
            MsgBox("Nothing to copy for you...", MsgBoxStyle.Exclamation, "Alert")
        Else
            My.Computer.Clipboard.SetText(Me.OutputText.Text)
        End If
    End Sub






    Private Sub CopyAllButton_Click(sender As Object, e As EventArgs) Handles CopyAllButton.Click
        CopyAll()
    End Sub

    Private Sub SaveAsButton_Click(sender As Object, e As EventArgs) Handles SaveAsButton.Click
        SaveAs()
    End Sub




    'Private Sub WYZtoCdataWin_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
    '    If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
    '        e.Effect = DragDropEffects.Copy
    '    Else
    '        e.Effect = DragDropEffects.None
    '    End If
    'End Sub



    'Private Sub WYZtoCdataWin_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
    '    Dim tmpstr() As String = e.Data.GetData("FileDrop", False)
    '    Dim filePath As String = tmpstr(0)

    '    Me.BringToFront()
    '    Me.Activate()

    '    If Path.GetExtension(filePath).ToUpper = ".MUS" Then
    '        LoadWYZ(filePath)
    '    End If

    'End Sub



    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        Dim aboutWin As New AboutForm()
        aboutWin.ShowDialog(Me)
    End Sub



    Private Function LoadTextFile(ByVal filePath As String) As ArrayList
        Dim objReader As StreamReader
        Dim dataText As ArrayList
        Dim sLine As String

        Try
            If File.Exists(filePath) Then

                dataText = New ArrayList()
                objReader = New StreamReader(filePath)

                Do
                    sLine = objReader.ReadLine()
                    If Not sLine Is Nothing Then
                        dataText.Add(sLine)
                    End If
                Loop Until sLine Is Nothing
                objReader.Close()

                Return dataText

            End If

        Catch ex As Exception

        End Try

        Return Nothing

    End Function



End Class
