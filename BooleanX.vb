Option Strict On

Namespace SjSd.SystemArea

    Partial Public Class DataTypes
        Public Class BooleanX



            Public ReadOnly Property Value() As Boolean?

            Public Sub New(ByVal value As Boolean)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Boolean?)
                Me.Value = value
            End Sub





            Public Shared Operator Not(ByVal left As BooleanX) As BooleanX

                If left.Value Is Nothing Then
                    Return New BooleanX(Nothing)
                ElseIf left.Value = True Then
                    Return New BooleanX(False)
                Else
                    Return New BooleanX(True)
                End If

            End Operator


            Public Shared Narrowing Operator CType(ByVal left As Boolean) As BooleanX
                Return New BooleanX(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Boolean?) As BooleanX
                Return New BooleanX(left)
            End Operator


        End Class


    End Class

End Namespace
