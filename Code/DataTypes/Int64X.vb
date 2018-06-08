Option Strict On



Namespace SjSd.SystemArea


    Partial Public Class DataTypesX
        Inherits IAcDataTypesX

        Public Class Int64X


            Implements IComparable(Of Int64X)
            'Implements IEquatable(Of Int64X)
            Implements IConvertible

            Implements IDataTypeX(Of Int64X)

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

            Public ReadOnly Property Value() As Int64?


            Public Sub New()
                Me.Value = Nothing
            End Sub

            Public Sub New(ByVal value As Int64)
                Me.Value = CType(value, Int64?)
            End Sub
            Public Sub New(ByVal value As Int64?)
                Me.Value = value
            End Sub
            Public Sub New(ByVal value As Int64X)
                Me.Value = value.Value
            End Sub

            Public Sub New(ByVal value As Int32)
                Me.Value = CType(value, Int64?)
            End Sub
            Public Sub New(ByVal value As Int32?)
                Me.Value = CType(value, Int64?)
            End Sub
            'Public Sub New(ByVal value As Int32X)
            '    Me.Value = value.Value
            'End Sub

            Public Sub New(ByVal value As Int16)
                Me.Value = CType(value, Int64?)
            End Sub
            Public Sub New(ByVal value As Int16?)
                Me.Value = CType(value, Int64?)
            End Sub
            'Public Sub New(ByVal value As Int16X)
            '    Me.Value = value.Value
            'End Sub

            Public Sub New(ByVal value As Decimal)
                Me.Value = CType(value, Int64?)
            End Sub
            Public Sub New(ByVal value As Decimal?)
                Me.Value = CType(value, Int64?)
            End Sub
            'Public Sub New(ByVal value As DecimalX)
            '    Me.Value = value.Value
            'End Sub


            Public Sub New(ByVal value As Double)
                Me.Value = CType(value, Int64?)
            End Sub
            Public Sub New(ByVal value As Double?)
                Me.Value = CType(value, Int64?)
            End Sub
            'Public Sub New(ByVal value As DoubleX)
            '    Me.Value = value.Value
            'End Sub

            Public Sub New(ByVal value As Single)
                Me.Value = CType(value, Int64?)
            End Sub
            Public Sub New(ByVal value As Single?)
                Me.Value = CType(value, Int64?)
            End Sub
            'Public Sub New(ByVal value As SingleX)
            '    Me.Value = value.Value
            'End Sub

            Public Sub New(ByVal value As Boolean)
                Me.Value = CType(value, Int64?)
            End Sub
            Public Sub New(ByVal value As Boolean?)
                Me.Value = CType(value, Int64?)
            End Sub
            Public Sub New(ByVal value As BooleanX)
                Me.Value = CType(value.Value, Int64?)
            End Sub





            ''' <summary>
            ''' Returns empty String if Value is Nothing/Null
            ''' </summary>
            ''' <returns></returns>
            Public Shadows Function ToString() As String

                If Value Is Nothing Then Return ""
                Return Value.ToString

            End Function

            ''' <summary>
            ''' Returns the given parameter String, if Value Is Nothing/Null
            ''' </summary>
            ''' <param name="returnStr"></param>
            ''' <returns></returns>
            Public Shadows Function ToString(Optional returnStr As String = "") As String

                If Value Is Nothing Then Return returnStr
                Return Value.ToString

            End Function


            ''' <summary>
            ''' If Not Value Is Nothing then Function returns Value, else ZERO
            ''' </summary>
            ''' <returns></returns>
            Public Function ToZero() As Int64X Implements IDataTypeX(Of Int64X).ToZero

                If Me._Value Is Nothing Then Return New Int64X(0) With {.Rules = Me.Rules}
                Return Me

            End Function



            Public Function CompareTo(ByVal other As Int64X) As Integer Implements IComparable(Of Int64X).CompareTo
                Return CInt(Me.Value - other.Value)
            End Function

            'Public Overloads Function Equals(ByVal other As Int64X) As Boolean Implements IEquatable(Of Int64X).Equals
            '    Return CBool(Me.Value = other.Value)
            'End Function

            Public Overloads Function Equals(ByVal other As Int64X) As BooleanX
                Return CType(Me.Value = other.Value, BooleanX)
            End Function

            Public Overrides Function GetHashCode() As Integer
                Return Value.GetHashCode
            End Function







#Region " = <> "



            '##########################################################
            '##########################################################
            '##########################################################
            '##########################################################
            ' = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

            ' AREA: (Identic Value)

            Public Shared Operator =(ByVal left As Int64X, ByVal right As Int64X) As BooleanX
                Return CType(left.Value = right.Value, BooleanX)
            End Operator



            ' AREA: (Identic Value) (Long / Int64)
            Public Shared Operator =(ByVal left As Int64X, ByVal right As Int64) As BooleanX

                Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), If(IsNothing(right), True, False), left.Rules.ValueComparing.ErrorRule)

                Select Case left.Rules.ValueComparing.OperationRule

                    Case RuleSet.ValueCompare.OperationRules.AlwaysNothing

                        If left.Value Is Nothing Then
                            Return New BooleanX With {.Rules = left.Rules} = Nothing
                        Else
                            Return New BooleanX(CBool(left.Value = right)) With {.Rules = left.Rules}
                        End If

                    Case RuleSet.ValueCompare.OperationRules.AsZero

                        Return New BooleanX(CBool(left.ToZero.Value = right)) With {.Rules = left.Rules}

                    Case RuleSet.ValueCompare.OperationRules.JustIgnore

                        If left.Value Is Nothing Then
                            Return New BooleanX(False) With {.Rules = left.Rules}
                        Else
                            Return New BooleanX(CBool(left.Value = right)) With {.Rules = left.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator =(ByVal left As Int64, ByVal right As Int64X) As BooleanX

                Call CheckErrorXRight(If(IsNothing(left), True, False), If(IsNothing(right.Value), True, False), right.Rules.ValueComparing.ErrorRule)

                Select Case right.Rules.ValueComparing.OperationRule

                    Case RuleSet.ValueCompare.OperationRules.AlwaysNothing

                        If right.Value Is Nothing Then
                            Return New BooleanX With {.Rules = right.Rules} = Nothing
                        Else
                            Return New BooleanX(left = right.Value) With {.Rules = right.Rules}
                        End If

                    Case RuleSet.ValueCompare.OperationRules.AsZero

                        Return New BooleanX(CBool(left = right.ToZero.Value)) With {.Rules = right.Rules}

                    Case RuleSet.ValueCompare.OperationRules.JustIgnore

                        If right.Value Is Nothing Then
                            Return New BooleanX(False) With {.Rules = right.Rules}
                        Else
                            Return New BooleanX(CBool(left = right.ToZero.Value)) With {.Rules = right.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator =(ByVal left As Int64X, ByVal right As Int64?) As BooleanX

                Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), If(IsNothing(right), True, False), left.Rules.ValueComparing.ErrorRule)

                Select Case left.Rules.ValueComparing.OperationRule

                    Case RuleSet.ValueCompare.OperationRules.AlwaysNothing

                        If left.Value Is Nothing Or right Is Nothing Then
                            Return New BooleanX With {.Rules = left.Rules} = Nothing
                        Else
                            Return New BooleanX(CBool(left.Value = right)) With {.Rules = left.Rules}
                        End If

                    Case RuleSet.ValueCompare.OperationRules.AsZero

                        If left.Value Is Nothing And right Is Nothing Then
                            Return New BooleanX With {.Rules = left.Rules} = True

                        ElseIf left.Value Is Nothing Then
                            Return New BooleanX(CBool(0 = right)) With {.Rules = left.Rules}

                        ElseIf right Is Nothing Then
                            Return New BooleanX(CBool(left.Value = 0)) With {.Rules = left.Rules}

                        Else
                            Return New BooleanX(CBool(left.Value = right)) With {.Rules = left.Rules}
                        End If

                    Case RuleSet.ValueCompare.OperationRules.JustIgnore

                        If left.Value Is Nothing And right Is Nothing Then
                            Return New BooleanX(True) With {.Rules = left.Rules}

                        ElseIf left.Value Is Nothing Then
                            Return New BooleanX(False) With {.Rules = left.Rules}

                        ElseIf right Is Nothing Then
                            Return New BooleanX(False) With {.Rules = left.Rules}

                        Else
                            Return New BooleanX(CBool(left.Value = right)) With {.Rules = left.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator =(ByVal left As Int64?, ByVal right As Int64X) As BooleanX

                Call CheckErrorXRight(If(IsNothing(left), True, False), If(IsNothing(right.Value), True, False), right.Rules.ValueComparing.ErrorRule)

                Select Case right.Rules.ValueComparing.OperationRule

                    Case RuleSet.ValueCompare.OperationRules.AlwaysNothing

                        If left Is Nothing Or right.Value Is Nothing Then
                            Return New BooleanX With {.Rules = right.Rules} = Nothing
                        Else
                            Return New BooleanX(CBool(left = right.Value)) With {.Rules = right.Rules}
                        End If

                    Case RuleSet.ValueCompare.OperationRules.AsZero

                        If left Is Nothing And right.Value Is Nothing Then
                            Return New BooleanX With {.Rules = right.Rules} = True

                        ElseIf left Is Nothing Then
                            Return New BooleanX(CBool(0 = right.Value)) With {.Rules = right.Rules}

                        ElseIf right.Value Is Nothing Then
                            Return New BooleanX(CBool(left = 0)) With {.Rules = right.Rules}

                        Else
                            Return New BooleanX(CBool(left = right.Value)) With {.Rules = right.Rules}
                        End If

                    Case RuleSet.ValueCompare.OperationRules.JustIgnore

                        If left Is Nothing And right.Value Is Nothing Then
                            Return New BooleanX(True) With {.Rules = right.Rules}

                        ElseIf left Is Nothing Then
                            Return New BooleanX(False) With {.Rules = right.Rules}

                        ElseIf right.Value Is Nothing Then
                            Return New BooleanX(False) With {.Rules = right.Rules}

                        Else
                            Return New BooleanX(CBool(left = right.Value)) With {.Rules = right.Rules}
                        End If

                End Select

            End Operator




            Public Shared Operator =(ByVal left As Int64X, ByVal right As Int32) As BooleanX
                Return left = CType(right, Int64?)
            End Operator
            Public Shared Operator =(ByVal left As Int32, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64?) = right
            End Operator
            'Public Shared Operator =(ByVal left As Int32X, ByVal right As Int64X) As BooleanX
            '    Return CType(left, Int64?) = right
            'End Operator

            Public Shared Operator =(ByVal left As Int64X, ByVal right As Int32?) As BooleanX
                Return left = CType(right, Int64?)
            End Operator
            Public Shared Operator =(ByVal left As Int32?, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64?) = right
            End Operator
            'Public Shared Operator =(ByVal left As Int64X, ByVal right As Int32X) As BooleanX
            '    Return left = CType(right, Int64?)
            'End Operator


            Public Shared Operator =(ByVal left As Int64X, ByVal right As Int16) As BooleanX
                Return left = CType(right, Int64?)
            End Operator
            Public Shared Operator =(ByVal left As Int16, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64?) = right
            End Operator
            Public Shared Operator =(ByVal left As Int64X, ByVal right As Int16?) As BooleanX
                Return left = CType(right, Int64?)
            End Operator
            Public Shared Operator =(ByVal left As Int16?, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64?) = right
            End Operator


            Public Shared Operator =(ByVal left As Int64X, ByVal right As Decimal) As BooleanX
                Return left = CType(right, Int64)
            End Operator
            Public Shared Operator =(ByVal left As Decimal, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64) = right
            End Operator
            Public Shared Operator =(ByVal left As Int64X, ByVal right As Decimal?) As BooleanX
                Return left = CType(right, Int64)
            End Operator
            Public Shared Operator =(ByVal left As Decimal?, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64) = right
            End Operator


            Public Shared Operator =(ByVal left As Int64X, ByVal right As Double) As BooleanX
                Return left = CType(right, Int64)
            End Operator
            Public Shared Operator =(ByVal left As Double, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64) = right
            End Operator
            Public Shared Operator =(ByVal left As Int64X, ByVal right As Double?) As BooleanX
                Return left = CType(right, Int64)
            End Operator
            Public Shared Operator =(ByVal left As Double?, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64) = right
            End Operator


            Public Shared Operator =(ByVal left As Int64X, ByVal right As Single) As BooleanX
                Return left = CType(right, Int64)
            End Operator
            Public Shared Operator =(ByVal left As Single, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64) = right
            End Operator
            Public Shared Operator =(ByVal left As Int64X, ByVal right As Single?) As BooleanX
                Return left = CType(right, Int64)
            End Operator
            Public Shared Operator =(ByVal left As Single?, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64) = right
            End Operator


            Public Shared Operator =(ByVal left As Int64X, ByVal right As Boolean) As BooleanX
                Return left = CType(right, Int64)
            End Operator
            Public Shared Operator =(ByVal left As Boolean, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64) = right
            End Operator
            Public Shared Operator =(ByVal left As Int64X, ByVal right As Boolean?) As BooleanX
                Return left = CType(right, Int64)
            End Operator
            Public Shared Operator =(ByVal left As Boolean?, ByVal right As Int64X) As BooleanX
                Return CType(left, Int64) = right
            End Operator


            ' Object
            Public Shared Operator =(ByVal left As Int64X, ByVal right As Object) As Boolean
                Throw New InvalidCastException("Cant compare given parameter. // Type: " & right.GetType.ToString & " >> .ToString: " & right.ToString & " with IntX")
            End Operator
            Public Shared Operator =(ByVal left As Object, ByVal right As Int64X) As Boolean
                Throw New InvalidCastException("Cant compare given parameter. // Type: " & left.GetType.ToString & " >> .ToString: " & left.ToString & " with IntX")
            End Operator




            '##########################################################
            '##########################################################
            '##########################################################
            '##########################################################
            ' <> <> <> <> <> <> <> <> <> <> <> <> <> <> <> <> <> <> <> 


            ' AREA: (NOT Identic Value)

            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator

            ' Long / Int64
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Int64) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Int64?) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64?, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator

            ' Integer / Int32
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Int32) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int32, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Int32?) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int32?, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator

            ' Short / Int16
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Int16) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int16, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Int16?) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int16?, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator

            ' Decimal
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Decimal) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Decimal, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Decimal?) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Decimal?, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator


            ' Double
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Double) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Double, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Double?) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Double?, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator


            ' Single
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Single) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Single, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Single?) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Single?, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator


            ' Boolean
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Boolean) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Boolean, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Boolean?) As BooleanX
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Boolean?, ByVal right As Int64X) As BooleanX
                Return Not (left = right)
            End Operator


            ' Object
            Public Shared Operator <>(ByVal left As Int64X, ByVal right As Object) As Boolean
                Return Not (left = right)
            End Operator
            Public Shared Operator <>(ByVal left As Object, ByVal right As Int64X) As Boolean
                Return Not (left = right)
            End Operator



#End Region '"= <>"

            '##########################################################
            '##########################################################
            '##########################################################
            '##########################################################
            ' + + + + + + + + + + + + + + + + + + + + + + + + + + + + 


            ' AREA: (PLUS)
#Region " + -"

            Public Shared Operator +(ByVal left As Int64X, ByVal right As Int64X) As Int64X

                If left.Value Is Nothing AndAlso right.Value Is Nothing Then
                    Return CType(0, Int64X)
                ElseIf left.Value Is Nothing Then
                    Return CType(right.Value, Int64X)
                ElseIf right.Value Is Nothing Then
                    Return CType(left.Value, Int64X)
                Else
                    Return CType(left.Value + right.Value, Int64X)
                End If

            End Operator




#Region "PLUS Int64 / Long"


            Public Shared Operator +(ByVal left As Int64X, ByVal right As Int64) As Int64X

                Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), If(IsNothing(right), True, False), left.Rules.Calculating.OpPlusMinus.ErrorRule)

                Select Case left.Rules.Calculating.OpPlusMinus.OperationRule

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AlwaysNothing

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AsZero

                        Return New Int64X(left.ToZero + right) With {.Rules = left.Rules}

                    Case RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore

                        If left.Value Is Nothing Then
                            Return New Int64X(right) With {.Rules = left.Rules}
                        Else
                            Return New Int64X(left.Value + right) With {.Rules = left.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator +(ByVal left As Int64, ByVal right As Int64X) As Int64X

                Call CheckErrorXRight(If(IsNothing(left), True, False), If(IsNothing(right.Value), True, False), right.Rules.Calculating.OpPlusMinus.ErrorRule)

                Select Case right.Rules.Calculating.OpPlusMinus.OperationRule

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AlwaysNothing

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AsZero

                        Return New Int64X(left + right.ToZero) With {.Rules = right.Rules}

                    Case RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore

                        If right.Value Is Nothing Then
                            Return New Int64X(left) With {.Rules = right.Rules}
                        Else
                            Return New Int64X(left + right.Value) With {.Rules = right.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator +(ByVal left As Int64X, ByVal right As Int64?) As Int64X

                Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), If(IsNothing(right), True, False), left.Rules.Calculating.OpPlusMinus.ErrorRule)

                Select Case left.Rules.Calculating.OpPlusMinus.OperationRule

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AlwaysNothing

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AsZero

                        If right Is Nothing Then
                            Return New Int64X(left.ToZero) With {.Rules = left.Rules}
                        Else
                            Return New Int64X(left.ToZero + right) With {.Rules = left.Rules}
                        End If

                    Case RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore

                        If left.Value Is Nothing And right Is Nothing Then
                            Return New Int64X(right) With {.Rules = left.Rules}
                        ElseIf right Is Nothing Then
                            Return left
                        ElseIf left.Value Is Nothing Then
                            Return New Int64X(right) With {.Rules = left.Rules}
                        Else
                            Return New Int64X(left.Value + right) With {.Rules = left.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator +(ByVal left As Int64?, ByVal right As Int64X) As Int64X


                Call CheckErrorXRight(If(IsNothing(left), True, False), If(IsNothing(right.Value), True, False), right.Rules.Calculating.OpPlusMinus.ErrorRule)

                Select Case right.Rules.Calculating.OpPlusMinus.OperationRule

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AlwaysNothing

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AsZero

                        If left Is Nothing Then
                            Return New Int64X(right.ToZero) With {.Rules = right.Rules}
                        Else
                            Return New Int64X(left + right.ToZero) With {.Rules = right.Rules}
                        End If

                    Case RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore

                        If right.Value Is Nothing And left Is Nothing Then
                            Return New Int64X(left) With {.Rules = right.Rules}
                        ElseIf left Is Nothing Then
                            Return right
                        ElseIf right.Value Is Nothing Then
                            Return New Int64X(left) With {.Rules = right.Rules}
                        Else
                            Return New Int64X(left + right.Value) With {.Rules = right.Rules}
                        End If

                End Select

            End Operator

#End Region ' PLUS Int64 / Long

            Public Shared Operator +(ByVal left As Int64X, ByVal right As Int32) As Int64X
                Return left + CType(right, Int64)
            End Operator
            Public Shared Operator +(ByVal left As Int32, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) + right
            End Operator
            Public Shared Operator +(ByVal left As Int64X, ByVal right As Int32?) As Int64X
                Return left + CType(right, Int64?)
            End Operator
            Public Shared Operator +(ByVal left As Int32?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) + right
            End Operator


            Public Shared Operator +(ByVal left As Int64X, ByVal right As Int16) As Int64X
                Return left + CType(right, Int64)
            End Operator
            Public Shared Operator +(ByVal left As Int16, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) + right
            End Operator
            Public Shared Operator +(ByVal left As Int64X, ByVal right As Int16?) As Int64X
                Return left + CType(right, Int64?)
            End Operator
            Public Shared Operator +(ByVal left As Int16?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) + right
            End Operator


            Public Shared Operator +(ByVal left As Int64X, ByVal right As Decimal) As Int64X
                Return left + CType(right, Int64)
            End Operator
            Public Shared Operator +(ByVal left As Decimal, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) + right
            End Operator
            Public Shared Operator +(ByVal left As Int64X, ByVal right As Decimal?) As Int64X
                Return left + CType(right, Int64?)
            End Operator
            Public Shared Operator +(ByVal left As Decimal?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) + right
            End Operator


            Public Shared Operator +(ByVal left As Int64X, ByVal right As Double) As Int64X
                Return left + CType(right, Int64)
            End Operator
            Public Shared Operator +(ByVal left As Double, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) + right
            End Operator
            Public Shared Operator +(ByVal left As Int64X, ByVal right As Double?) As Int64X
                Return left + CType(right, Int64?)
            End Operator
            Public Shared Operator +(ByVal left As Double?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) + right
            End Operator


            Public Shared Operator +(ByVal left As Int64X, ByVal right As Single) As Int64X
                Return left + CType(right, Int64)
            End Operator
            Public Shared Operator +(ByVal left As Single, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) + right
            End Operator
            Public Shared Operator +(ByVal left As Int64X, ByVal right As Single?) As Int64X
                Return left + CType(right, Int64?)
            End Operator
            Public Shared Operator +(ByVal left As Single?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) + right
            End Operator

            ' TODO: Bool addieren
            Public Shared Operator +(ByVal left As Int64X, ByVal right As Boolean) As Boolean
                Throw New NotImplementedException()
                ' If CType(left.Value, Boolean) + CType(right, Boolean) = True Then Return True Else Return False
            End Operator
            Public Shared Operator +(ByVal left As Boolean, ByVal right As Int64X) As Int64X
                Throw New NotImplementedException()
                ' Return CType(CType(left, Long?) + right.Value, IntX)
            End Operator


            '##########################################################
            '##########################################################
            ' - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            '##########################################################
            '##########################################################

            ' AREA: (MINUS)


            Public Shared Operator -(ByVal left As Int64X, ByVal right As Int64X) As Int64X
            End Operator


            Public Shared Operator -(ByVal left As Int64X, ByVal right As Int64) As Int64X

                Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), If(IsNothing(right), True, False), left.Rules.Calculating.OpPlusMinus.ErrorRule)

                Select Case left.Rules.Calculating.OpPlusMinus.OperationRule

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AlwaysNothing

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AsZero

                        Return New Int64X(left.ToZero - right) With {.Rules = left.Rules}

                    Case RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore

                        If left.Value Is Nothing Then
                            Return New Int64X(right) With {.Rules = left.Rules}
                        Else
                            Return New Int64X(left.Value - right) With {.Rules = left.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator -(ByVal left As Int64, ByVal right As Int64X) As Int64X

                Call CheckErrorXRight(If(IsNothing(left), True, False), If(IsNothing(right.Value), True, False), right.Rules.Calculating.OpPlusMinus.ErrorRule)

                Select Case right.Rules.Calculating.OpPlusMinus.OperationRule

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AlwaysNothing

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AsZero

                        Return New Int64X(left - right.ToZero) With {.Rules = right.Rules}

                    Case RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore

                        If right.Value Is Nothing Then
                            Return New Int64X(left) With {.Rules = right.Rules}
                        Else
                            Return New Int64X(left - right.Value) With {.Rules = right.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator -(ByVal left As Int64X, ByVal right As Int64?) As Int64X

                Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), If(IsNothing(right), True, False), left.Rules.Calculating.OpPlusMinus.ErrorRule)

                Select Case left.Rules.Calculating.OpPlusMinus.OperationRule

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AlwaysNothing

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AsZero

                        If right Is Nothing Then
                            Return New Int64X(left.ToZero) With {.Rules = left.Rules}
                        Else
                            Return New Int64X(left.ToZero - right) With {.Rules = left.Rules}
                        End If

                    Case RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore

                        If left.Value Is Nothing And right Is Nothing Then
                            Return New Int64X(right) With {.Rules = left.Rules}
                        ElseIf right Is Nothing Then
                            Return left
                        ElseIf left.Value Is Nothing Then
                            Return New Int64X(right) With {.Rules = left.Rules}
                        Else
                            Return New Int64X(left.Value + right) With {.Rules = left.Rules}
                        End If

                End Select

            End Operator

            Public Shared Operator -(ByVal left As Int64?, ByVal right As Int64X) As Int64X

                Call CheckErrorXRight(If(IsNothing(left), True, False), If(IsNothing(right.Value), True, False), right.Rules.Calculating.OpPlusMinus.ErrorRule)

                Select Case right.Rules.Calculating.OpPlusMinus.OperationRule

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AlwaysNothing

                    Case RuleSet.Calculate.PlusMinus.OperationRules.AsZero

                        If left Is Nothing Then
                            Return New Int64X(right.ToZero) With {.Rules = right.Rules}
                        Else
                            Return New Int64X(left - right.ToZero) With {.Rules = right.Rules}
                        End If

                    Case RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore

                        If right.Value Is Nothing And left Is Nothing Then
                            Return New Int64X(left) With {.Rules = right.Rules}
                        ElseIf left Is Nothing Then
                            Return right
                        ElseIf right.Value Is Nothing Then
                            Return New Int64X(left) With {.Rules = right.Rules}
                        Else
                            Return New Int64X(left - right.Value) With {.Rules = right.Rules}
                        End If

                End Select

            End Operator


            ' AREA: (MINUS) (All other then Int64)

            Public Shared Operator -(ByVal left As Int64X, ByVal right As Int32) As Int64X
                Return left - CType(right, Int64)
            End Operator
            Public Shared Operator -(ByVal left As Int32, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) - right
            End Operator
            Public Shared Operator -(ByVal left As Int64X, ByVal right As Int32?) As Int64X
                Return left - CType(right, Int64?)
            End Operator
            Public Shared Operator -(ByVal left As Int32?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) - right
            End Operator


            Public Shared Operator -(ByVal left As Int64X, ByVal right As Int16) As Int64X
                Return left - CType(right, Int64)
            End Operator
            Public Shared Operator -(ByVal left As Int16, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) - right
            End Operator
            Public Shared Operator -(ByVal left As Int64X, ByVal right As Int16?) As Int64X
                Return left - CType(right, Int64?)
            End Operator
            Public Shared Operator -(ByVal left As Int16?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) - right
            End Operator


            Public Shared Operator -(ByVal left As Int64X, ByVal right As Decimal) As Int64X
                Return left - CType(right, Int64)
            End Operator
            Public Shared Operator -(ByVal left As Decimal, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) - right
            End Operator
            Public Shared Operator -(ByVal left As Int64X, ByVal right As Decimal?) As Int64X
                Return left - CType(right, Int64?)
            End Operator
            Public Shared Operator -(ByVal left As Decimal?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) - right
            End Operator


            Public Shared Operator -(ByVal left As Int64X, ByVal right As Double) As Int64X
                Return left - CType(right, Int64)
            End Operator
            Public Shared Operator -(ByVal left As Double, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) - right
            End Operator
            Public Shared Operator -(ByVal left As Int64X, ByVal right As Double?) As Int64X
                Return left - CType(right, Int64?)
            End Operator
            Public Shared Operator -(ByVal left As Double?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) - right
            End Operator


            Public Shared Operator -(ByVal left As Int64X, ByVal right As Single) As Int64X
                Return left - CType(right, Int64)
            End Operator
            Public Shared Operator -(ByVal left As Single, ByVal right As Int64X) As Int64X
                Return CType(left, Int64) - right
            End Operator
            Public Shared Operator -(ByVal left As Int64X, ByVal right As Single?) As Int64X
                Return left - CType(right, Int64?)
            End Operator
            Public Shared Operator -(ByVal left As Single?, ByVal right As Int64X) As Int64X
                Return CType(left, Int64?) - right
            End Operator



            Public Shared Operator -(ByVal left As Int64X, ByVal right As Boolean) As Int64X
                Return CType(left.Value - CType(right, Long?), Int64X)
            End Operator

            Public Shared Operator -(ByVal left As Boolean, ByVal right As Int64X) As Int64X
                Return CType(CType(left, Long?) - right.Value, Int64X)
            End Operator




#End Region '  + -

            ' AREA: (MULTI) 

            Public Shared Operator *(ByVal left As Int64X, ByVal right As Int64X) As Int64X
                Return CType(left.Value * right.Value, Int64X)
            End Operator


            ' AREA: (MULTI) (Int64)

            Public Shared Operator *(ByVal left As Int64X, ByVal right As Int64) As Int64X

                'Call CheckErrorXLeft(If(IsNothing(left.Value), True, False), If(IsNothing(right), True, False), left.Rules.Calculating.ErrorRule)

                'Select Case left.Rules.Calculating.OperationRule

                '    Case RuleSet.OperationRules.AsZero

                '        Return New IntX(left.ToZero * right) With {.Rules = left.Rules}

                '    Case RuleSet.OperationRules.JustIgnore

                '        If left.Value Is Nothing Then
                '            Return New IntX(right) With {.Rules = left.Rules}
                '        Else
                '            Return New IntX(left.Value * right) With {.Rules = left.Rules}
                '        End If

                'End Select

            End Operator



            Public Shared Operator *(ByVal left As Int64, ByVal right As Int64X) As Int64X




                ' Return CType(left.Value * right.Value, IntX)
            End Operator


            ' AREA: (DIVISION) 

            Public Shared Operator /(ByVal left As Int64X, ByVal right As Int64X) As Double
                Return CDbl(left.Value / right.Value)
            End Operator

            Public Shared Operator \(ByVal left As Int64X, ByVal right As Int64X) As Int64X
                Return CType(left.Value \ right.Value, Int64X)
            End Operator

            Public Shared Operator Mod(ByVal left As Int64X, ByVal right As Int64X) As Int64X
                Return CType(left.Value Mod right.Value, Int64X)
            End Operator

            Public Shared Operator And(ByVal left As Int64X, ByVal right As Int64X) As Int64X
                Return CType(left.Value And right.Value, Int64X)
            End Operator

            Public Shared Operator Or(ByVal left As Int64X, ByVal right As Int64X) As Int64X
                Return CType(left.Value Or right.Value, Int64X)
            End Operator

            Public Shared Operator Xor(ByVal left As Int64X, ByVal right As Int64X) As Int64X
                Return CType(left.Value Xor right.Value, Int64X)
            End Operator

            Public Shared Operator ^(ByVal left As Int64X, ByVal right As Int64X) As Double
                Return CDbl(left.Value ^ right.Value)
            End Operator

            Public Shared Operator <(ByVal left As Int64X, ByVal right As Int64X) As Boolean
                Return CBool(left.Value < right.Value)
            End Operator

            Public Shared Operator >(ByVal left As Int64X, ByVal right As Int64X) As Boolean
                Return CBool(left.Value > right.Value)
            End Operator

            Public Shared Operator <=(ByVal left As Int64X, ByVal right As Int64X) As Boolean
                Return CBool(left.Value <= right.Value)
            End Operator

            Public Shared Operator >=(ByVal left As Int64X, ByVal right As Int64X) As Boolean
                Return CBool(left.Value >= right.Value)
            End Operator


            ' AREA: (Widening)

            Public Shared Widening Operator CType(ByVal left As Int64X) As Int64
                Return CType(left.Value, Int64)
            End Operator
            Public Shared Widening Operator CType(ByVal left As Int64X) As Int64?
                Return left.Value
            End Operator

            Public Shared Widening Operator CType(ByVal left As Int64X) As Int32
                Return CType(left.Value, Int32)
            End Operator
            Public Shared Widening Operator CType(ByVal left As Int64X) As Int32?
                Return CType(left.Value, Int32?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As Int64X) As Int32X
            '    Return CType(left.Value, Int32X)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As Int64X) As Int16
                Return CType(left.Value, Int16)
            End Operator
            Public Shared Widening Operator CType(ByVal left As Int64X) As Int16?
                Return CType(left.Value, Int16?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As Int64X) As Int16X
            '    Return CType(left.Value, Int16X)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As Int64X) As Decimal
                Return CType(left.Value, Decimal)
            End Operator
            Public Shared Widening Operator CType(ByVal left As Int64X) As Decimal?
                Return CType(left.Value, Decimal?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As Int64X) As DecimalX
            '    Return CType(left.Value, DecimalX)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As Int64X) As Double
                Return CType(left.Value, Double)
            End Operator
            Public Shared Widening Operator CType(ByVal left As Int64X) As Double?
                Return CType(left.Value, Double?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As Int64X) As DoubleX
            '    Return CType(left.Value, DoubleX)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As Int64X) As Single
                Return CType(left.Value, Single)
            End Operator
            Public Shared Widening Operator CType(ByVal left As Int64X) As Single?
                Return CType(left.Value, Single?)
            End Operator
            'Public Shared Widening Operator CType(ByVal left As Int64X) As SingleX
            '    Return CType(left.Value, SingleX)
            'End Operator

            Public Shared Widening Operator CType(ByVal left As Int64X) As Boolean
                Return CType(left.Value, Boolean)
            End Operator
            Public Shared Widening Operator CType(ByVal left As Int64X) As Boolean?
                Return CType(left.Value, Boolean?)
            End Operator
            Public Shared Widening Operator CType(ByVal left As Int64X) As BooleanX
                Return CType(left.Value, BooleanX)
            End Operator


            ' AREA: (Narrowing)

            Public Shared Narrowing Operator CType(ByVal left As Int64) As Int64X
                Return New Int64X(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Int64?) As Int64X
                Return New Int64X(left)
            End Operator



            Public Shared Narrowing Operator CType(ByVal left As Int32) As Int64X
                Return New Int64X(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Int32?) As Int64X
                Return New Int64X(left)
            End Operator
            'Public Shared Narrowing Operator CType(ByVal left As Int32X) As Int64X
            '    Return New Int64X(left)
            'End Operator

            Public Shared Narrowing Operator CType(ByVal left As Int16) As Int64X
                Return New Int64X(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Int16?) As Int64X
                Return New Int64X(left)
            End Operator
            'Public Shared Narrowing Operator CType(ByVal left As Int16X) As Int64X
            '    Return New Int64X(left)
            'End Operator

            Public Shared Narrowing Operator CType(ByVal left As Decimal) As Int64X
                Return New Int64X(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Decimal?) As Int64X
                Return New Int64X(left)
            End Operator
            'Public Shared Narrowing Operator CType(ByVal left As DecimalX) As Int64X
            '    Return New Int64X(left)
            'End Operator

            Public Shared Narrowing Operator CType(ByVal left As Double) As Int64X
                Return New Int64X(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Double?) As Int64X
                Return New Int64X(left)
            End Operator
            'Public Shared Narrowing Operator CType(ByVal left As DoubleX) As Int64X
            '    Return New Int64X(left)
            'End Operator

            Public Shared Narrowing Operator CType(ByVal left As Single) As Int64X
                Return New Int64X(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Single?) As Int64X
                Return New Int64X(left)
            End Operator
            'Public Shared Narrowing Operator CType(ByVal left As SingleX) As Int64X
            '    Return New Int64X(left)
            'End Operator

            Public Shared Narrowing Operator CType(ByVal left As Boolean) As Int64X
                Return New Int64X(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As Boolean?) As Int64X
                Return New Int64X(left)
            End Operator
            Public Shared Narrowing Operator CType(ByVal left As BooleanX) As Int64X
                Return New Int64X(left)
            End Operator





#Region "IConvertible"


            Public Function GetTypeCode() As TypeCode Implements IConvertible.GetTypeCode
                Throw New NotImplementedException()
            End Function

            Public Function ToBoolean(provider As IFormatProvider) As Boolean Implements IConvertible.ToBoolean
                Throw New NotImplementedException()
            End Function

            Public Function ToChar(provider As IFormatProvider) As Char Implements IConvertible.ToChar
                Throw New NotImplementedException()
            End Function

            Public Function ToSByte(provider As IFormatProvider) As SByte Implements IConvertible.ToSByte
                Throw New NotImplementedException()
            End Function

            Public Function ToByte(provider As IFormatProvider) As Byte Implements IConvertible.ToByte
                Throw New NotImplementedException()
            End Function

            Public Function ToInt16(provider As IFormatProvider) As Short Implements IConvertible.ToInt16
                Throw New NotImplementedException()
            End Function

            Public Function ToUInt16(provider As IFormatProvider) As UShort Implements IConvertible.ToUInt16
                Throw New NotImplementedException()
            End Function

            Public Function ToInt32(provider As IFormatProvider) As Integer Implements IConvertible.ToInt32
                Throw New NotImplementedException()
            End Function

            Public Function ToUInt32(provider As IFormatProvider) As UInteger Implements IConvertible.ToUInt32
                Throw New NotImplementedException()
            End Function

            Public Function ToInt64(provider As IFormatProvider) As Long Implements IConvertible.ToInt64
                Throw New NotImplementedException()
            End Function

            Public Function ToUInt64(provider As IFormatProvider) As ULong Implements IConvertible.ToUInt64
                Throw New NotImplementedException()
            End Function

            Public Function ToSingle(provider As IFormatProvider) As Single Implements IConvertible.ToSingle
                Throw New NotImplementedException()
            End Function

            Public Function ToDouble(provider As IFormatProvider) As Double Implements IConvertible.ToDouble
                Throw New NotImplementedException()
            End Function

            Public Function ToDecimal(provider As IFormatProvider) As Decimal Implements IConvertible.ToDecimal
                Throw New NotImplementedException()
            End Function

            Public Function ToDateTime(provider As IFormatProvider) As Date Implements IConvertible.ToDateTime
                Throw New NotImplementedException()
            End Function

            Public Shadows Function ToString(provider As IFormatProvider) As String Implements IConvertible.ToString
                Throw New NotImplementedException()
            End Function

            Public Function ToType(conversionType As Type, provider As IFormatProvider) As Object Implements IConvertible.ToType
                Throw New NotImplementedException()
            End Function


#End Region ' IConvertible


        End Class


    End Class

End Namespace




'Select Case right.Rules.Calculating.OpPlusMinus.ErrorRule

'    Case RuleSet.ErrorRaisingTypes.NoError

'    Case RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem
'        If left Is Nothing Or right.Value Is Nothing Then Throw New Exception("Any operation with NULL/NOTHING is forbidden by Error Rule")

'    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyBoth
'        If left Is Nothing And right.Value Is Nothing Then Throw New Exception("Operation with both operands with NULL/NOTHING is forbidden by Error Rule")

'    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyMe
'        If right.Value Is Nothing Then Throw New Exception("Operation with IntX with NULL/NOTHING is forbidden by Error Rule")

'    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyOther
'        If left Is Nothing Then Throw New Exception("Operation with primitive DataTypes with NULL/NOTHING is forbidden by Error Rule")

'End Select

'Select Case left.Rules.Calculating.OpPlusMinus.ErrorRule

'    Case RuleSet.ErrorRaisingTypes.NoError

'    Case RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem
'        If left.Value Is Nothing Or right Is Nothing Then Throw New Exception("Any operation with NULL/NOTHING is forbidden by Error Rule")

'    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyBoth
'        If left.Value Is Nothing And right Is Nothing Then Throw New Exception("Operation with both operands with NULL/NOTHING is forbidden by Error Rule")

'    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyMe
'        If left.Value Is Nothing Then Throw New Exception("Operation with IntX with NULL/NOTHING is forbidden by Error Rule")

'    Case RuleSet.ErrorRaisingTypes.RaiseErrOnlyOther
'        If right Is Nothing Then Throw New Exception("Operation with primitive with NULL/NOTHING is forbidden by Error Rule")

'End Select


