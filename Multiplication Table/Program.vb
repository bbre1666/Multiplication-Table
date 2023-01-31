Option Explicit On
Option Strict On
Imports System

'Baden Brenner
'RCET0265
'spring 2023
'Multiplication Table
'https://github.com/bbre1666/Multiplication-Table.git


Module Program
    Dim size As Integer
    Sub Main(args As String())
        Console.WriteLine("what size table do you want?")
        size = CInt(Console.ReadLine())
        For col = 1 To size
            For row = 1 To size
                Console.Write(Str(col * row).PadLeft(8))
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
