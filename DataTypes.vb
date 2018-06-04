Option Strict On

Namespace SjSd.SystemArea

    Partial Public Class DataTypes


        Public Class RuleSet


            Public Enum ErrorRaisingTypes
                NoError
                RaiseErrOneOfThem
                RaiseErrOnlyBoth
                RaiseErrOnlyOther
                RaiseErrOnlyMe
            End Enum

            Public Enum SortRules
                AsZero
                AsLowest
                AsBiggest
                RaiseError
            End Enum

            Public Enum EqualRules
                AsZeroAndNothing
                AsNothing
            End Enum

            Public Property Sorting As SortRules = SortRules.AsLowest
            Public Property Equaling As EqualRules = EqualRules.AsNothing

            Private _Calculating As Calculate
            Public Property Calculating As Calculate
                Get
                    If _Calculating Is Nothing Then _Calculating = New Calculate
                    Return _Calculating
                End Get
                Set
                    _Calculating = Value
                End Set
            End Property
            Public Class Calculate

                '''' <summary>
                '''' Use this RuleSet for operations with primitive DataTypes
                '''' </summary>
                '''' <returns></returns>
                'Public Property OperationRule As OperationRules = OperationRules.JustIgnore
                '''' <summary>
                '''' Use this RuleSet for operations with extended DataTypes only.
                '''' </summary>
                '''' <returns></returns>
                'Public Property OperationRuleX As OperationRules = OperationRules.JustIgnore

                'Public Property ErrorRule As DataTypes.RuleSet.ErrorRaisingTypes = ErrorRaisingTypes.NoError
                'Public Property ErrorRuleX As DataTypes.RuleSet.ErrorRaisingTypes = ErrorRaisingTypes.NoError




                Public Property OpDivision As Division


                Private _OpPlusMinus As PlusMinus
                Public Property OpPlusMinus As PlusMinus
                    Get
                        If _OpPlusMinus Is Nothing Then _OpPlusMinus = New PlusMinus
                        Return _OpPlusMinus
                    End Get
                    Set
                        _OpPlusMinus = Value
                    End Set
                End Property
                Public Class PlusMinus

                    Public Enum OperationRules

                        ''' <summary>
                        ''' NOTHING/NULL is handled like ZERO
                        ''' </summary>
                        AsZero

                        ''' <summary>
                        ''' Difference to 'As Zero' is that if both are NOTHING/NULL then NOTHING/NULL, not ZERO is returned. 
                        ''' </summary>
                        JustIgnore

                        ''' <summary>
                        ''' Use this, if NULL/NOTHING should be returned, if one of the operands is NULL/NOTHING
                        ''' </summary>
                        AlwaysNothing
                    End Enum



                    ''' <summary>
                    ''' Use this RuleSet for operations with primitive DataTypes
                    ''' </summary>
                    ''' <returns></returns>
                    Public Property OperationRule As OperationRules = OperationRules.JustIgnore
                    ''' <summary>
                    ''' Use this RuleSet for operations with extended DataTypes only.
                    ''' </summary>
                    ''' <returns></returns>
                    Public Property OperationRuleX As OperationRules = OperationRules.JustIgnore

                    Public Property ErrorRule As DataTypes.RuleSet.ErrorRaisingTypes = ErrorRaisingTypes.NoError
                    Public Property ErrorRuleX As DataTypes.RuleSet.ErrorRaisingTypes = ErrorRaisingTypes.NoError


                End Class


                Public Property OpMultiplicate As Multiplicate
                Public Class Multiplicate

                    Public Enum Rules
                        AsZero
                        JustIgnore
                        RaiseErrOnlyOther
                        RaiseErrOnlyOtherBut
                        RaiseErrBoth
                    End Enum

                    Public Property Calculating As Rules = Rules.JustIgnore

                End Class

                Public Class Division

                    Public Enum Rules
                        AsZero
                        JustIgnore
                        RaiseErrOnlyOther
                        RaiseErrOnlyOtherBut
                        RaiseErrBoth
                    End Enum

                    Public Property Calculating As Rules = Rules.JustIgnore

                End Class

            End Class


            Private _ValueComparing As ValueCompare
            Public Property ValueComparing As ValueCompare
                Get
                    If _ValueComparing Is Nothing Then _ValueComparing = New ValueCompare
                    Return _ValueComparing
                End Get
                Set
                    _ValueComparing = Value
                End Set
            End Property
            Public Class ValueCompare

                Public Enum OperationRules

                    ''' <summary>
                    ''' NOTHING/NULL is handled like ZERO
                    ''' </summary>
                    AsZero

                    ''' <summary>
                    ''' Difference to 'As Zero' is that if both are NOTHING/NULL then NOTHING/NULL, not ZERO is returned. 
                    ''' </summary>
                    JustIgnore

                    ''' <summary>
                    ''' Use this, if NULL/NOTHING should be returned, if one of the operands is NULL/NOTHING
                    ''' </summary>
                    AlwaysNothing
                End Enum


                ''' <summary>
                ''' Use this RuleSet for operations with primitive DataTypes
                ''' </summary>
                ''' <returns></returns>
                Public Property OperationRule As OperationRules = OperationRules.JustIgnore
                ''' <summary>
                ''' Use this RuleSet for operations with extended DataTypes only.
                ''' </summary>
                ''' <returns></returns>
                Public Property OperationRuleX As OperationRules = OperationRules.JustIgnore

                Public Property ErrorRule As DataTypes.RuleSet.ErrorRaisingTypes = ErrorRaisingTypes.NoError
                Public Property ErrorRuleX As DataTypes.RuleSet.ErrorRaisingTypes = ErrorRaisingTypes.NoError

            End Class


        End Class


    End Class

End Namespace
