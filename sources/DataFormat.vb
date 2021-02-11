Public Class DataFormat

    ''' <summary>
    ''' Provides the last line number used in BASIC, with its increase.
    ''' Proporciona el último número de linea utilizada en BASIC, con su incremento.
    ''' </summary>
    ''' <remarks></remarks>
    Public BASIClineNumber As Short

    'Private Const C_CONSTANT_DEFINITION As String = "const unsigned char "


    ' dec nnn
    ' dec nnnd
    ' hex FF
    ' hex 0xFF
    ' hex FF$
    ' hex FF#
    ' hex 0FFh
    Public Shadows Enum ByteDataFormat As Byte
        DECIMAL_n = 0         '1
        DECIMAL_nnn = 11      '001
        DECIMAL_nnnd = 1      '001d

        HEXADECIMAL_nn = 2    'FF
        HEXADECIMAL_0xnn = 3  '0xFF
        HEXADECIMAL_Snn = 4   '$FF
        HEXADECIMAL_4nn = 5   '#FF
        HEXADECIMAL_0nnh = 6  '0FFh
        HEXADECIMAL_yHnn = 7  '&hFF

        BINARY_n = 8   ' 00000000
        BINARY_nb = 9  ' 00000000b
        BINARY_percentn = 10 ' %00000000
    End Enum


    Public Shadows Enum OutputFormat As Byte
        ASSEMBLER
        BASIC
        C
    End Enum



    ''' <summary>
    ''' Provides the formatted data to be used in MSX BASIC.
    ''' Proporciona los datos formateados para ser usados en BASIC de MSX.
    ''' </summary>
    ''' <param name="tmpData"></param>
    ''' <param name="itemsPerLine"></param>
    ''' <param name="format"></param>
    ''' <param name="firstNumLine"></param>
    ''' <param name="incLine"></param>
    ''' <param name="comment"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBasicCode(ByVal tmpData() As Object, ByVal itemsPerLine As Byte, ByVal format As ByteDataFormat, ByVal removeZeros As Boolean, ByVal firstNumLine As Short, ByVal incLine As Byte, ByVal comment As ArrayList) As String

        Dim outputString As String = ""

        Dim contador As Integer = 0

        Dim line As String

        Dim i As Integer = 0
        Dim o As Integer = 0

        Dim tmpCalc As Short

        Dim tableSize As Short
        tableSize = tmpData.Length - 1


        outputString = GetComments(comment, OutputFormat.BASIC, firstNumLine, incLine)
        'Me.BASIClineNumber = firstNumLine

        'If Not comment Is Nothing Then
        '    For Each commentValue As String In comment
        '        outputString += CStr(Me.BASIClineNumber) + " REM " + commentValue + vbNewLine
        '        Me.BASIClineNumber += incLine
        '    Next
        'End If

        tmpCalc = -Int(-((tableSize + 1) / itemsPerLine))

        For i = 1 To tmpCalc
            line = CStr(Me.BASIClineNumber) + " DATA "
            For o = 0 To itemsPerLine - 2
                If (contador < tableSize) Then
                    line += getBasicFormatedValue(tmpData(contador), format, removeZeros) + ","
                    contador += 1
                ElseIf (contador = tableSize) Then  ' ultimo de la linea
                    line += getBasicFormatedValue(tmpData(contador), format, removeZeros)
                    contador += 1
                End If
            Next
            If Not (contador > tableSize) Then ' ultimo de la linea
                line += getBasicFormatedValue(tmpData(contador), format, removeZeros)
                contador += 1
            End If

            outputString += line + vbNewLine
            Me.BASIClineNumber += incLine
        Next

        Return outputString

    End Function



    ''' <summary>
    ''' Provides data formatted for use in C.
    ''' Proporciona los datos formateados para ser usados en C.
    ''' </summary>
    ''' <param name="tmpData"></param>
    ''' <param name="itemsPerLine"></param>
    ''' <param name="format"></param>
    ''' <param name="fieldName"></param>
    ''' <param name="comment"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCodeInC(ByVal tmpData() As Object, ByVal itemsPerLine As Byte, ByVal format As ByteDataFormat, ByVal fieldName As String, ByVal comment As ArrayList, ByVal dataCommand As String) As String

        Dim outputString As String = ""

        Dim contador As Integer = 0
        Dim line As String

        Dim i As Integer = 0
        Dim o As Integer = 0

        Dim tmpCalc As Short

        Dim tmpValue As Object
        Dim formatedVale As String

        Dim tableSize As Integer
        tableSize = tmpData.Length - 1



        'If Not commentText = "" Then
        '    outputString += "// " + commentText + vbNewLine
        'End If

        outputString = GetComments(comment, OutputFormat.C, 0, 0)

        'If Not comment Is Nothing Then
        '    For Each commentValue As String In comment
        '        outputString += "// " + commentValue + vbNewLine
        '    Next
        'End If


        line = dataCommand + " " + GetCFieldFormat(fieldName) + "[]={" '.Replace(" ", "_")
        outputString += line + vbNewLine

        tmpCalc = -Int(-((tableSize + 1) / itemsPerLine))

        For i = 1 To tmpCalc
            line = ""
            For o = 0 To itemsPerLine - 1

                tmpValue = tmpData(contador)
                formatedVale = GetFormatedValue(tmpValue, format)

                If (contador < tableSize) Then
                    line += tmpValue + ","
                    contador += 1
                Else
                    If (contador = tableSize) Then
                        line += tmpValue + "};"
                        contador += 1
                    End If
                End If
            Next
            outputString += line + vbNewLine
        Next

        Return outputString

    End Function



    ''' <summary>
    ''' Provides data formatted for use on Z80 Assembler.
    ''' Proporciona los datos formateados para ser usados en Ensamblador de Z80.
    ''' </summary>
    ''' <param name="tmpData"></param>
    ''' <param name="itemsPerLine"></param>
    ''' <param name="format"></param>
    ''' <param name="fieldName"></param>
    ''' <param name="comment"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAsmCode(ByVal tmpData() As Object, ByVal itemsPerLine As Byte, ByVal format As ByteDataFormat, ByVal fieldName As String, ByVal comment As ArrayList, ByVal dataCommand As String) As String

        Dim outputString As String = ""

        Dim contador As Integer = 0
        Dim line As String

        Dim i As Integer = 0
        Dim o As Integer = 0

        Dim tmpCalc As Short

        Dim formatedVale As String

        Dim tableSize As Short
        tableSize = tmpData.Length - 1


        'If itemsPerLine < 8 Then
        '    itemsPerLine = tmpData.Length
        'End If

        outputString = GetComments(comment, OutputFormat.ASSEMBLER, 0, 0)

        'If Not comment Is Nothing Then
        '    For Each commentValue As String In comment
        '        outputString += "; " + commentValue + vbNewLine
        '    Next
        'End If


        If Not fieldName = "" Then
            outputString += GetAsmFieldFormat(fieldName) + ":" + vbNewLine '.Replace(" ", "_")
        End If

        tmpCalc = -Int(-((tableSize + 1) / itemsPerLine))

        For i = 1 To tmpCalc
            line = dataCommand + " "
            For o = 0 To itemsPerLine - 2

                If Not (contador > tableSize) Then

                    formatedVale = GetFormatedValue(tmpData(contador), format)

                    If (contador < tableSize) Then
                        line += formatedVale + ","
                        contador += 1
                    ElseIf (contador = tableSize) Then
                        line += formatedVale
                        contador += 1
                    End If

                End If
            Next
            If Not (contador > tableSize) Then
                line += GetFormatedValue(tmpData(contador), format)
                contador += 1
            End If

            outputString += line + vbNewLine
        Next

        Return outputString

    End Function





    ''' <summary>
    ''' Proporciona un valor formateado para BASIC.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getBasicFormatedValue(ByVal value As Byte, ByVal format As ByteDataFormat, ByVal removeZeros As Boolean) As String

        Dim outputData As String = ""

        If removeZeros Then
            If value = 0 Then
                outputData = ""
            Else
                If format = ByteDataFormat.HEXADECIMAL_nn Then
                    outputData = Hex(value)
                Else
                    outputData = GetFormatedValue(value, format)
                End If
            End If
        Else
            outputData = GetFormatedValue(value, format)
        End If

        Return outputData

    End Function




    Private Function GetFormatedValue(ByVal value As Object, ByVal format As ByteDataFormat) As String

        Dim outputData As String = "0"

        Dim decSize As Integer = 3
        Dim hexSize As Integer = 2
        Dim binSize As Integer = 8


        If TypeOf value Is Short Then
            decSize = 5
            hexSize = 4
            binSize = 16
        End If


        Select Case format

            Case ByteDataFormat.DECIMAL_n
                outputData = CStr(value)

            Case ByteDataFormat.DECIMAL_nnn
                outputData = CStr(value).PadLeft(decSize, "0"c)

            Case ByteDataFormat.DECIMAL_nnnd
                outputData = CStr(value).PadLeft(decSize, "0"c) + "d"

            Case ByteDataFormat.HEXADECIMAL_nn
                outputData = Hex(value).PadLeft(hexSize, "0"c)

            Case ByteDataFormat.HEXADECIMAL_0nnh
                outputData = "0" + Hex(value).PadLeft(hexSize, "0"c) + "h"

            Case ByteDataFormat.HEXADECIMAL_0xnn
                outputData = "0x" + Hex(value).PadLeft(hexSize, "0"c)

            Case ByteDataFormat.HEXADECIMAL_4nn
                outputData = "#" + Hex(value).PadLeft(hexSize, "0"c)

            Case ByteDataFormat.HEXADECIMAL_Snn
                outputData = "$" + Hex(value).PadLeft(hexSize, "0"c)

            Case ByteDataFormat.HEXADECIMAL_yHnn
                outputData = "&H" + Hex(value).PadLeft(hexSize, "0"c)

            Case ByteDataFormat.BINARY_n
                outputData = Convert.ToString(value, 2).PadLeft(binSize, "0"c)

            Case ByteDataFormat.BINARY_nb
                outputData = Convert.ToString(value, 2).PadLeft(binSize, "0"c) + "b"

            Case ByteDataFormat.BINARY_percentn
                outputData = "%" + Convert.ToString(value, 2).PadLeft(binSize, "0"c)

        End Select

        Return outputData

    End Function




    ''' <summary>
    ''' Proporciona un valor en hexadecimal de 8 bits.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetHexByte(ByVal value As Byte) As String
        'Dim hexvalue As String = "00" + Hex(avalue)
        'Return hexvalue.Substring(hexvalue.Length - 2, 2)
        Return Hex(value).PadLeft(2, "0"c)
    End Function



    ''' <summary>
    ''' Proporciona un valor hexadecimal de 16 bits.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetHexWord(ByVal value As Short) As String
        'Dim hexvalue As String = "0000" + Hex(avalue)
        'Return hexvalue.Substring(hexvalue.Length - 4, 4)
        Return Hex(value).PadLeft(4, "0"c)
    End Function



    Public Function JoinDataHex(ByVal aData As Byte()) As String
        Dim anOutput As String = ""
        Dim i As Integer

        For i = 0 To aData.Length - 1
            anOutput += GetHexByte(aData(i))
        Next

        Return anOutput
    End Function



    Public Function JoinDataHex(ByVal aData As Array) As String
        Dim anOutput As String = ""
        Dim i As Integer

        For i = 0 To aData.Length - 1
            anOutput += GetHexByte(aData(i))
        Next

        Return anOutput
    End Function



    Public Function ByteSpliterHex(ByVal data As String) As Byte()
        Dim tmpData As Byte()

        Dim size As Integer = (data.Length / 2) - 1
        ReDim tmpData(size)

        For i As Integer = 0 To size
            tmpData(i) = Byte.Parse((data.Substring(i * 2, 2)), System.Globalization.NumberStyles.HexNumber)
        Next

        Return tmpData
    End Function



    Public Function ByteSpliter(ByVal data As String, ByVal size As Integer, ByVal initpos As Integer) As Byte()
        Dim genData As New mSXdevtools.WYZtoSDCCobj.DataFormat
        If data.IndexOf(",") = -1 Then
            Return genData.ByteSpliterHex(data, size, initpos)
        Else
            Return genData.ByteSpliter(data, size, initpos, 0)
        End If
    End Function



    Public Function ByteSpliterHex(ByVal data As String, ByVal size As Integer, ByVal initpos As Integer) As Byte()
        Dim tmpData As Byte()
        Dim counter As Integer = 0

        ReDim tmpData(size)

        If (data.Length / 2) < (size + 1) Then
            data += New String("0", 64) 'add 32(*2) hex values
        End If

        For i As Integer = initpos To initpos + size
            tmpData(counter) = Byte.Parse((data.Substring(i * 2, 2)), System.Globalization.NumberStyles.HexNumber)
            counter += 1
        Next

        Return tmpData
    End Function



    ''' <summary>
    ''' DEPRECATED, Para compatibilidad con el formato del MSXtiles devtool.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="size"></param>
    ''' <param name="initpos"></param>
    ''' <param name="defaultvalue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ByteSpliter(ByVal data As String, ByVal size As Integer, ByVal initpos As Integer, ByVal defaultvalue As Byte) As Byte()
        Dim tmpData As Byte()
        Dim numitems As Integer = 0
        Dim counter As Integer = 0

        Dim defaultString As String = "," + CStr(defaultvalue)

        'data += ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"
        For i As Integer = 0 To 31
            data += defaultString
        Next

        ReDim tmpData(size)

        Dim splitdata As String() = data.Split(",")
        numitems = splitdata.GetLength(0)

        For i As Integer = initpos To initpos + size
            tmpData(counter) = CByte(splitdata(i))
            counter += 1
        Next

        Return tmpData
    End Function



    Public Function GetAsmFieldFormat(field As String) As String
        Dim formatedField As String

        formatedField = field.Trim
        formatedField = formatedField.Replace(" ", "_")
        formatedField = formatedField.Replace(".", "_")
        formatedField = formatedField.Replace("(", "")
        formatedField = formatedField.Replace(")", "")

        Return formatedField
    End Function



    Public Function GetCFieldFormat(field As String) As String
        Dim formatedField As String

        formatedField = field.Trim
        formatedField = formatedField.Replace(" ", "_")
        formatedField = formatedField.Replace(".", "_")
        formatedField = formatedField.Replace("(", "")
        formatedField = formatedField.Replace(")", "")

        Return formatedField
    End Function



    Public Function GetComments(ByVal comment As ArrayList, ByVal format As OutputFormat, ByVal firstNumLine As Short, ByVal incLine As Byte) As String
        Dim outputString As String = ""

        Me.BASIClineNumber = firstNumLine

        If Not comment Is Nothing Then
            For Each commentValue As String In comment

                Select Case format
                    Case OutputFormat.C
                        outputString += "// " + commentValue + vbNewLine

                    Case OutputFormat.BASIC
                        outputString += CStr(Me.BASIClineNumber) + " REM " + commentValue + vbNewLine
                        Me.BASIClineNumber += incLine

                    Case Else
                        'OutputFormat.ASSEMBLER
                        outputString += "; " + commentValue + vbNewLine

                End Select

            Next
        End If

        Return outputString

    End Function


End Class

