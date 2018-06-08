Namespace SjSd.SystemArea


    ''' <summary>
    ''' Helper Stuff Shared In Parent. Inerited by <see cref="DataTypesX"/>
    ''' </summary>
    Public MustInherit Class IAcDataTypesX

        Friend Shared Sub CheckErrorXLeft(leftXIsNothing As Boolean, rightOtherIsNothing As Boolean, errorRuleSet As DataTypesX.RuleSet.ErrorRaisingTypes)

            Select Case errorRuleSet

                Case DataTypesX.RuleSet.ErrorRaisingTypes.NoError

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem
                    If leftXIsNothing Or rightOtherIsNothing Then Throw New Exception("Any operation with NULL/NOTHING is forbidden by Error Rule")

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyBoth
                    If leftXIsNothing And rightOtherIsNothing Then Throw New Exception("Operation with both operands with NULL/NOTHING is forbidden by Error Rule")

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyMe
                    If rightOtherIsNothing Then Throw New Exception("Operation with primitive DataTypes with NULL/NOTHING is forbidden by Error Rule")

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyOther
                    If leftXIsNothing Then Throw New Exception("Operation with IntX with NULL/NOTHING is forbidden by Error Rule")

            End Select

        End Sub

        Friend Shared Sub CheckErrorXRight(leftOtherIsNothing As Boolean, rightXIsNothing As Boolean, errorRuleSet As DataTypesX.RuleSet.ErrorRaisingTypes)

            Select Case errorRuleSet

                Case DataTypesX.RuleSet.ErrorRaisingTypes.NoError

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem
                    If leftOtherIsNothing Or rightXIsNothing Then Throw New Exception("Any operation with NULL/NOTHING is forbidden by Error Rule")

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyBoth
                    If leftOtherIsNothing And rightXIsNothing Then Throw New Exception("Operation with both operands with NULL/NOTHING is forbidden by Error Rule")

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyMe
                    If rightXIsNothing Then Throw New Exception("Operation with IntX with NULL/NOTHING is forbidden by Error Rule")

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyOther
                    If leftOtherIsNothing Then Throw New Exception("Operation with primitive with NULL/NOTHING is forbidden by Error Rule")

            End Select

        End Sub

        Friend Shared Sub CheckErrorXOnlyLeft(leftXIsNothing As Boolean, errorRuleSet As DataTypesX.RuleSet.ErrorRaisingTypes)

            Select Case errorRuleSet

                Case DataTypesX.RuleSet.ErrorRaisingTypes.NoError

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem
                    If leftXIsNothing Then Throw New Exception("Any operation with NULL/NOTHING is forbidden by Error Rule")

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyBoth
                    If leftXIsNothing Then Throw New Exception("Operation with both operands with NULL/NOTHING is forbidden by Error Rule")

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyMe

                Case DataTypesX.RuleSet.ErrorRaisingTypes.RaiseErrOnlyOther

            End Select

        End Sub



    End Class

End Namespace

