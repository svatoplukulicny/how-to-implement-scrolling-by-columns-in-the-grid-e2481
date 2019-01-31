Imports System.ComponentModel

Namespace WindowsApplication3
    Public NotInheritable Class ItemList

        Private Sub New()
        End Sub

        Public Shared Function GetList() As BindingList(Of Item)
            Dim list = New BindingList(Of Item)()
            For i As Integer = 0 To 49
                list.Add(New Item() With { _
                    .Column1 = "Test1" & i, _
                    .Column2 = "Test2" & i, _
                    .Column3 = "Test3" & i, _
                    .Column4 = "Test4" & i, _
                    .Column5 = "Test5" & i, _
                    .Column6 = "Test6" & i, _
                    .Column7 = "Test7" & i, _
                    .Column8 = "Test8" & i, _
                    .Column9 = "Test9" & i, _
                    .Column10 = "Test10" & i, _
                    .Column11 = "Test11" & i, _
                    .Column12 = "Test12" & i, _
                    .Column13 = "Test13" & i, _
                    .Column14 = "Test14" & i, _
                    .Column15 = "Test15" & i, _
                    .Column16 = "Test16" & i _
                })
            Next i
            Return list
        End Function
    End Class
    Public Class Item
        Public Property Column1() As String
        Public Property Column2() As String
        Public Property Column3() As String
        Public Property Column4() As String
        Public Property Column5() As String
        Public Property Column6() As String
        Public Property Column7() As String
        Public Property Column8() As String
        Public Property Column9() As String
        Public Property Column10() As String
        Public Property Column11() As String
        Public Property Column12() As String
        Public Property Column13() As String
        Public Property Column14() As String
        Public Property Column15() As String
        Public Property Column16() As String
    End Class
End Namespace
