Option Strict Off

Namespace SjSd.SystemArea

    Partial Public Class DataTypesX
        Public Class BooleanX
            Inherits IAcDataTypesX

            Implements IDataTypeX(Of BooleanX)

            Private _Rules As RuleSet
            Public Property Rules As RuleSet
                Get

                    If _Rules Is Nothing Then _Rules = New RuleSet
                    Return _Rules
                End Get
                Set
                    _Rules = Value
                End Set
            End Property

            Public ReadOnly Property Value() As Boolean? 'Implements IDataTypeX(Of BooleanX).Value


            Public Function ToZero() As BooleanX Implements IDataTypeX(Of BooleanX).ToZero
                Throw New NotImplementedException()
            End Function


            Public Sub New()
                Me.Value = Nothing
            End Sub

            Public Sub New(ByVal value As Boolean)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Boolean?)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As BooleanX)
                Me.Value = value.Value
            End Sub

            Public Sub New(ByVal value As Int64)
                Me.Value = CBool(value)
            End Sub
            Public Sub New(ByVal value As Int64?)
                Me.Value = CBool(value)
            End Sub
            Public Sub New(ByVal value As Int64X)
                Me.Value = CBool(value)
            End Sub

            Public Sub New(ByVal value As Int32)
                Me.Value = CBool(value)
            End Sub
            Public Sub New(ByVal value As Int32?)
                Me.Value = value
            End Sub
            'Public Sub New(ByVal value As Int32X)
            '    Me.Value = CBool(value)
            'End Sub

            Public Sub New(ByVal value As Int16)
                Me.Value = CBool(value)
            End Sub
            Public Sub New(ByVal value As Int16?)
                Me.Value = CBool(value)
            End Sub
            'Public Sub New(ByVal value As Int16X)
            '    Me.Value = CBool(value)
            'End Sub

            Public Sub New(ByVal value As Decimal)
                Me.Value = CBool(value)
            End Sub
            Public Sub New(ByVal value As Decimal?)
                Me.Value = CBool(value)
            End Sub
            'Public Sub New(ByVal value As DecimalX)
            '    Me.Value = CBool(value)
            'End Sub

            Public Sub New(ByVal value As Double)
                Me.Value = CBool(value)
            End Sub
            Public Sub New(ByVal value As Double?)
                Me.Value = CBool(value)
            End Sub
            'Public Sub New(ByVal value As DoubleX)
            '    Me.Value = CBool(value)
            'End Sub

            Public Sub New(ByVal value As Single)
                Me.Value = CBool(value)
            End Sub
            Public Sub New(ByVal value As Single?)
                Me.Value = CBool(value)
            End Sub
            'Public Sub New(ByVal value As SingleX)
            '    Me.Value = CBool(value)
            'End Sub


            ' AREA: ( ===== )

            Public Shared Operator =(ByVal left As BooleanX, ByVal right As BooleanX) As BooleanX

            End Operator


            Friend Shared Function LeftXAndRightWithOutNothing() As BooleanX



            End Function


            Public Shared Operator =(ByVal left As BooleanX, ByVal right As Boolean) As BooleanX

                Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), If(IsNothing(right), True, False), left.Rules.ValueComparing.ErrorRule)

                Select Case left.Rules.ValueComparing.OperationRule

                    Case RuleSet.ValueCompare.OperationRules.AlwaysNothing

                        If left.Value Is Nothing Then
                            Return New BooleanX() With {.Rules = left.Rules} = Nothing
                        Else
                            Return New BooleanX(CBool(left.Value = right)) With {.Rules = left.Rules}
                        End If

                    Case RuleSet.ValueCompare.OperationRules.AsZero

                        If left.Value Is Nothing Then
                            Return New BooleanX(CBool(left.ToZero) = right) With {.Rules = left.Rules}

                        End If

                        'Return New BooleanX(left.ToZero = right)

                    Case RuleSet.ValueCompare.OperationRules.JustIgnore

                        If left.Value Is Nothing Then
                            Return New BooleanX(False) With {.Rules = left.Rules}
                        Else
                            Return New BooleanX(CBool(left.Value = right)) With {.Rules = left.Rules}
                        End If

                End Select

            End Operator
            Public Shared Operator =(ByVal left As Boolean, ByVal right As BooleanX) As BooleanX

            End Operator
            Public Shared Operator =(ByVal left As BooleanX, ByVal right As Boolean?) As BooleanX

            End Operator

            Public Shared Operator =(ByVal left As Boolean?, ByVal right As BooleanX) As BooleanX

            End Operator



            Public Shared Operator =(ByVal left As BooleanX, ByVal right As Int64) As BooleanX

            End Operator
            Public Shared Operator =(ByVal left As BooleanX, ByVal right As Int64?) As BooleanX

            End Operator
            Public Shared Operator =(ByVal left As BooleanX, ByVal right As Int64X) As BooleanX

            End Operator
            Public Shared Operator =(ByVal left As Int64, ByVal right As BooleanX) As BooleanX

            End Operator
            Public Shared Operator =(ByVal left As Int64?, ByVal right As BooleanX) As BooleanX

            End Operator
            Public Shared Operator =(ByVal left As Int64X, ByVal right As BooleanX) As BooleanX

            End Operator



            ' AREA: ( <><><><> )

            Public Shared Operator <>(ByVal left As BooleanX, ByVal right As BooleanX) As BooleanX

            End Operator


            Public Shared Operator <>(ByVal left As BooleanX, ByVal right As Boolean) As BooleanX

            End Operator
            Public Shared Operator <>(ByVal left As Boolean, ByVal right As BooleanX) As BooleanX

            End Operator
            Public Shared Operator <>(ByVal left As BooleanX, ByVal right As Boolean?) As BooleanX

            End Operator

            Public Shared Operator <>(ByVal left As Boolean?, ByVal right As BooleanX) As BooleanX

            End Operator



            Public Shared Operator <>(ByVal left As BooleanX, ByVal right As Int64) As BooleanX

            End Operator
            Public Shared Operator <>(ByVal left As BooleanX, ByVal right As Int64?) As BooleanX

            End Operator
            Public Shared Operator <>(ByVal left As BooleanX, ByVal right As Int64X) As BooleanX

            End Operator
            Public Shared Operator <>(ByVal left As Int64, ByVal right As BooleanX) As BooleanX

            End Operator
            Public Shared Operator <>(ByVal left As Int64?, ByVal right As BooleanX) As BooleanX

            End Operator
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As BooleanX) As BooleanX

            End Operator






            Public Shared Operator Not(ByVal left As BooleanX) As BooleanX

                Call CheckErrorXOnlyLeft(If(IsNothing(left.Value), True, False), left.Rules.ValueComparing.ErrorRule)

                ' I cant see nessesary of Select Case "...ValueComparing.OperationRule". It is always done before by comparing itself.
                ' In bitwise operanding it looks of course different. 
                Select Case left.Rules.ValueComparing.OperationRule
                    Case RuleSet.ValueCompare.OperationRules.AlwaysNothing
                    Case RuleSet.ValueCompare.OperationRules.AsZero
                    Case RuleSet.ValueCompare.OperationRules.JustIgnore
                End Select

                If left.Value Is Nothing Then
                    Return left

                ElseIf left.Value = True Then
                    Return New BooleanX(False) With {.Rules = left.Rules}

                ElseIf left.Value = False Then
                    Return New BooleanX(True) With {.Rules = left.Rules}

                Else
                    ' doesnt exist.... only for better reading 
                End If

            End Operator



            ' AREA: (Widening)

            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int64
                Return CType(left.Value, Int64)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int64?
                Return CType(left.Value, Int64?)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int64X
                Return CType(left.Value, Int64X)
            End Operator

            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int32
                Return CType(left.Value, Int32)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int32?
                Return CType(left.Value, Int32?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As BooleanX) As Int32X
            '    Return CType(left.Value, Int32X)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int16
                Return CType(left.Value, Int16)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int16?
                Return CType(left.Value, Int16?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As BooleanX) As Int16X
            '    Return CType(left.Value, Int16X)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As BooleanX) As Decimal
                Return CType(left.Value, Decimal)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Decimal?
                Return CType(left.Value, Decimal?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As BooleanX) As DecimalX
            '    Return CType(left.Value, DecimalX)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As BooleanX) As Double
                Return CType(left.Value, Double)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Double?
                Return CType(left.Value, Double?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As BooleanX) As DoubleX
            '    Return CType(left.Value, DecimalX)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As BooleanX) As Single
                Return CType(left.Value, Single)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Single?
                Return CType(left.Value, Single?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As BooleanX) As SingleX
            '    Return CType(left.Value, SingleX)
            'End Operator


            Public Shared Widening Operator CType(ByVal left As BooleanX) As Boolean
                Return CType(left.Value, Boolean)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Boolean?
                Return CType(left.Value, Boolean?)
            End Operator




            ' AREA: (Narrowing)

            Public Shared Narrowing Operator CType(ByVal left As Int64) As BooleanX
                Return New BooleanX(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Int64?) As BooleanX
                Return New BooleanX(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Int64X) As BooleanX
                Return New BooleanX(left)
            End Operator

            Public Shared Narrowing Operator CType(ByVal left As Int32) As BooleanX
                Return New BooleanX(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Int32?) As BooleanX
                Return New BooleanX(left)
            End Operator
            'Public Shared Narrowing Operator CType(ByVal left As Int32X) As BooleanX
            '    Return New BooleanX(left)
            'End Operator




            Public Shared Narrowing Operator CType(ByVal left As Boolean) As BooleanX
                Return New BooleanX(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Boolean?) As BooleanX
                Return New BooleanX(left)
            End Operator


            ' ###############
            Private Sub Ende()
            End Sub
            ' ###############



        End Class


    End Class

End Namespace
