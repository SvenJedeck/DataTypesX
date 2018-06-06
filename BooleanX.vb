Option Strict Off

Namespace SjSd.SystemArea

    Partial Public Class DataTypes
        Public Class BooleanX

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

            Public ReadOnly Property Value() As Boolean?



            Private Shared Sub CheckErrorXLeft(leftXIsNothing As Boolean, rightOtherIsNothing As Boolean, errorRuleSet As RuleSet.ErrorRaisingTypes)

                Select Case errorRuleSet

                    Case RuleSet.ErrorRaisingTypes.NoError

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem
                        If leftXIsNothing Or rightOtherIsNothing Then Throw New Exception("Any operation with NULL/NOTHING is forbidden by Error Rule")

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyBoth
                        If leftXIsNothing And rightOtherIsNothing Then Throw New Exception("Operation with both operands with NULL/NOTHING is forbidden by Error Rule")

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyMe
                        If rightOtherIsNothing Then Throw New Exception("Operation with primitive DataTypes with NULL/NOTHING is forbidden by Error Rule")

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyOther
                        If leftXIsNothing Then Throw New Exception("Operation with IntX with NULL/NOTHING is forbidden by Error Rule")

                End Select

            End Sub

            Private Shared Sub CheckErrorXLeft(leftXIsNothing As Boolean, errorRuleSet As RuleSet.ErrorRaisingTypes)

                Select Case errorRuleSet

                    Case RuleSet.ErrorRaisingTypes.NoError

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem
                        If leftXIsNothing Then Throw New Exception("Any operation with NULL/NOTHING is forbidden by Error Rule")

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyBoth
                        If leftXIsNothing Then Throw New Exception("Operation with both operands with NULL/NOTHING is forbidden by Error Rule")

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyMe

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyOther

                End Select

            End Sub

            Private Shared Sub CheckErrorXRight(leftOtherIsNothing As Boolean, rightXIsNothing As Boolean, errorRuleSet As RuleSet.ErrorRaisingTypes)

                Select Case errorRuleSet

                    Case RuleSet.ErrorRaisingTypes.NoError

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem
                        If leftOtherIsNothing Or rightXIsNothing Then Throw New Exception("Any operation with NULL/NOTHING is forbidden by Error Rule")

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyBoth
                        If leftOtherIsNothing And rightXIsNothing Then Throw New Exception("Operation with both operands with NULL/NOTHING is forbidden by Error Rule")

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyMe
                        If rightXIsNothing Then Throw New Exception("Operation with IntX with NULL/NOTHING is forbidden by Error Rule")

                    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyOther
                        If leftOtherIsNothing Then Throw New Exception("Operation with primitive with NULL/NOTHING is forbidden by Error Rule")

                End Select

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
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Int64?)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Int64X)
                Me.Value = value.Value
            End Sub


            Public Sub New(ByVal value As Int32)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Int32?)
                Me.Value = value
            End Sub
            'Public Sub New(ByVal value As Int32X)
            '    Me.Value = value.Value
            'End Sub

            Public Sub New(ByVal value As Int16)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Int16?)
                Me.Value = value
            End Sub
            'Public Sub New(ByVal value As Int16X)
            '    Me.Value = value.Value
            'End Sub

            Public Sub New(ByVal value As Decimal)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Decimal?)
                Me.Value = value
            End Sub
            'Public Sub New(ByVal value As DecimalX)
            '    Me.Value = value.Value
            'End Sub

            Public Sub New(ByVal value As Double)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Double?)
                Me.Value = value
            End Sub
            'Public Sub New(ByVal value As DoubleX)
            '    Me.Value = value.Value
            'End Sub

            Public Sub New(ByVal value As Single)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Single?)
                Me.Value = value
            End Sub
            'Public Sub New(ByVal value As SingleX)
            '    Me.Value = value.Value
            'End Sub



            'Public Shared Operator =-(ByVal left As BooleanX, ByVal right As Boolean) As BooleanX

            'End Operator



            Public Shared Operator =(ByVal left As BooleanX, ByVal right As Boolean) As BooleanX

            End Operator
            Public Shared Operator <>(ByVal left As BooleanX, ByVal right As Boolean) As BooleanX

            End Operator




            'Public Shared Operator =(ByVal left As Int64X, ByVal right As Int64) As BooleanX

            'End Operator


            'Public Shared Operator <>(ByVal left As Int64X, ByVal right As Int64) As BooleanX

            'End Operator









            Public Shared Operator Not(ByVal left As BooleanX) As BooleanX

                Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), left.Rules.ValueComparing.ErrorRule)



                If left.Value Is Nothing Then
                    Return left
                ElseIf left.Value = True Then
                    Return New BooleanX(False) With {.Rules = left.Rules}
                Else
                    Return New BooleanX(True) With {.Rules = left.Rules}
                End If

            End Operator





            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int64
                Return CType(left.Value, Int64)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int64?
                Return CType(left.Value, Int64?)
            End Operator

            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int32
                Return CType(left.Value, Int32)
            End Operator
            Public Shared Widening Operator CType(ByVal left As BooleanX) As Int32?
                Return CType(left.Value, Int32?)
            End Operator



            Public Shared Narrowing Operator CType(ByVal left As Int64) As BooleanX
                Return New BooleanX(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Int64?) As BooleanX
                Return New BooleanX(left)
            End Operator

            Public Shared Narrowing Operator CType(ByVal left As Int32) As BooleanX
                Return New BooleanX(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Int32?) As BooleanX
                Return New BooleanX(left)
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
