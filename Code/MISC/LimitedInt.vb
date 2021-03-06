﻿Namespace SjSd.SystemArea



    Partial Public Class DataTypesX
        Structure LimitedInt
            Implements IComparable(Of LimitedInt)
            Implements IEquatable(Of LimitedInt)

            Private m_Value As Integer 'treat the default, 0 as being really 1'

            Public ReadOnly Property Value() As Integer
                Get
                    Return If(m_Value = 0, 1, m_Value)
                End Get
            End Property

            Public Sub New(ByVal value As Integer)
                If value < 1 Or value > 10 Then Throw New ArgumentOutOfRangeException("value")
                m_Value = value
            End Sub

            Public Function CompareTo(ByVal other As LimitedInt) As Integer Implements IComparable(Of LimitedInt).CompareTo
                Return Me.Value - other.Value
            End Function

            Public Overloads Function Equals(ByVal other As LimitedInt) As Boolean Implements IEquatable(Of LimitedInt).Equals
                Return Me.Value = other.Value
            End Function

            Public Overrides Function GetHashCode() As Integer
                Return Value.GetHashCode
            End Function

            Public Overrides Function Equals(ByVal obj As Object) As Boolean
                If TypeOf obj Is LimitedInt Then Return CType(obj, LimitedInt) = Me
                Return False
            End Function

            Public Shared Operator =(ByVal left As LimitedInt, ByVal right As LimitedInt) As Boolean
                Return left.Equals(right)
            End Operator

            Public Shared Operator <>(ByVal left As LimitedInt, ByVal right As LimitedInt) As Boolean
                Return Not (left = right)
            End Operator

            Public Shared Operator +(ByVal left As LimitedInt, ByVal right As LimitedInt) As LimitedInt
                Dim temp As Integer = left.Value + right.Value
                Select Case temp
                    Case 1 To 10 : Return New LimitedInt(temp)
                    Case Else : Throw New OverflowException
                End Select
            End Operator

            Public Shared Operator -(ByVal left As LimitedInt, ByVal right As LimitedInt) As LimitedInt
                Dim temp As Integer = left.Value - right.Value
                Select Case temp
                    Case 1 To 10 : Return New LimitedInt(temp)
                    Case Else : Throw New OverflowException
                End Select
            End Operator

            Public Shared Operator *(ByVal left As LimitedInt, ByVal right As LimitedInt) As LimitedInt
                Dim temp As Integer = left.Value * right.Value
                Select Case temp
                    Case 1 To 10 : Return New LimitedInt(temp)
                    Case Else : Throw New OverflowException
                End Select
            End Operator

            Public Shared Operator /(ByVal left As LimitedInt, ByVal right As LimitedInt) As Double
                Return left.Value / right.Value
            End Operator

            Public Shared Operator \(ByVal left As LimitedInt, ByVal right As LimitedInt) As LimitedInt
                Dim temp As Integer = left.Value \ right.Value
                Select Case temp
                    Case 1 To 10 : Return New LimitedInt(temp)
                    Case Else : Throw New OverflowException
                End Select
            End Operator

            Public Shared Operator Mod(ByVal left As LimitedInt, ByVal right As LimitedInt) As LimitedInt
                Dim temp As Integer = left.Value Mod right.Value
                Select Case temp
                    Case 1 To 10 : Return New LimitedInt(temp)
                    Case Else : Throw New OverflowException
                End Select
            End Operator

            Public Shared Operator And(ByVal left As LimitedInt, ByVal right As LimitedInt) As LimitedInt
                Dim temp As Integer = left.Value And right.Value
                Select Case temp
                    Case 1 To 10 : Return New LimitedInt(temp)
                    Case Else : Throw New OverflowException
                End Select
            End Operator

            Public Shared Operator Or(ByVal left As LimitedInt, ByVal right As LimitedInt) As LimitedInt
                Dim temp As Integer = left.Value Or right.Value
                Select Case temp
                    Case 1 To 10 : Return New LimitedInt(temp)
                    Case Else : Throw New OverflowException
                End Select
            End Operator

            Public Shared Operator Xor(ByVal left As LimitedInt, ByVal right As LimitedInt) As LimitedInt
                Dim temp As Integer = left.Value Xor right.Value
                Select Case temp
                    Case 1 To 10 : Return New LimitedInt(temp)
                    Case Else : Throw New OverflowException
                End Select
            End Operator

            Public Shared Operator ^(ByVal left As LimitedInt, ByVal right As LimitedInt) As Double
                Return left.Value ^ right.Value
            End Operator

            Public Shared Operator <(ByVal left As LimitedInt, ByVal right As Integer) As Boolean
                Return left.Value < right
            End Operator

            Public Shared Operator >(ByVal left As LimitedInt, ByVal right As Integer) As Boolean
                Return left.Value > right
            End Operator

            Public Shared Operator <=(ByVal left As LimitedInt, ByVal right As LimitedInt) As Boolean
                Return left.Value <= right.Value
            End Operator

            Public Shared Operator >=(ByVal left As LimitedInt, ByVal right As LimitedInt) As Boolean
                Return left.Value >= right.Value
            End Operator

            Public Shared Widening Operator CType(ByVal left As LimitedInt) As Integer
                Return left.Value
            End Operator

            Public Shared Narrowing Operator CType(ByVal left As Integer) As LimitedInt
                Return New LimitedInt(left)
            End Operator

        End Structure


    End Class

End Namespace
