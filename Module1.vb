Option Strict Off

Imports SjSd.SystemArea.DataTypes


Module Module1

    Sub Main()


        Dim MyOwnInt As IntX = 10
        Dim a2 As IntX = 2
        Dim aDouble As IntX = -2.6
        Dim aN As IntX = Nothing


        Dim MyInt16 As Int16 = 2
        Dim MyInt32 As Int32 = 2
        Dim MyInt64 As Int64 = 2
        Dim MyDec As Decimal = 2
        Dim MyDouble As Double = 2.8
        Dim MySingle As Single = 2
        Dim MyBool As Boolean = True

        Dim MyInt16N As Int16? = Nothing
        Dim MyInt32N As Int32? = Nothing
        Dim MyInt64N As Int64? = Nothing
        Dim MyDecN As Decimal? = Nothing
        Dim MyDoubleN As Double? = Nothing
        Dim MySingleN As Single? = Nothing
        Dim MyBoolN As Boolean? = Nothing

        aN.Rules.Calculating.OpPlusMinus.OperationRule = RuleSet.Calculate.PlusMinus.OperationRules.JustIgnore
        'a1.Rules.Calculating.OpPlusMinus.ErrorRule = RuleSet.ErrorRaisingTypes.RaiseErrOneOfThem



        Dim tmp = MyDouble - MyOwnInt

        Stop


        'tmp = MyInt64N <> MyOwnInt
        'tmp = MyInt64N <> a2
        'tmp = MyInt64N <> aDouble
        'tmp = MyInt64N <> aN

        'tmp = MyDouble <> MyOwnInt
        'tmp = MyDouble <> a2
        'tmp = MyInt64 <> aDouble
        'tmp = MyDec <> aN


        'tmp = MyOwnInt <> MyInt64N
        'tmp = a2 <> MyInt64N
        'tmp = aDouble <> MyInt64N
        'tmp = aN <> MyInt64N

        'tmp = MyOwnInt <> MyInt64
        'tmp = a2 <> MyInt64
        'tmp = aDouble <> MyInt64
        'tmp = aN <> MyInt64

        MyOwnInt.Rules.ValueComparing.OperationRule = RuleSet.ValueCompare.OperationRules.AsZero
        a2.Rules.ValueComparing.OperationRule = RuleSet.ValueCompare.OperationRules.AsZero
        aDouble.Rules.ValueComparing.OperationRule = RuleSet.ValueCompare.OperationRules.AsZero
        aN.Rules.ValueComparing.OperationRule = RuleSet.ValueCompare.OperationRules.AsZero

        tmp = MyInt64N = MyOwnInt
        tmp = MyInt64N = a2
        tmp = MyInt64N = aDouble
        tmp = MyInt64N = aN

        tmp = MyInt64 = MyOwnInt
        tmp = MyInt64 = a2
        tmp = MyInt64 = aDouble
        tmp = MyInt64 = aN


        tmp = MyOwnInt = MyInt64N
        tmp = a2 = MyInt64N
        tmp = aDouble = MyInt64N
        tmp = aN = MyInt64

        tmp = MyOwnInt = MyInt64
        tmp = a2 = MyInt64
        tmp = aDouble = MyInt64
        tmp = aN = MyInt64



        Stop


        'Console.WriteLine("----------")

        'Dim MyResultEquals As Boolean

        'MyResultEquals = a0 = MyInt16

        'MyResultEquals = MyInt16 = a0



        'MyResultEquals = a0 = MyInt16N


        'MyResultEquals = MyInt16N = a0



        'Console.WriteLine("----------")

        'Dim MyResultCalc As IntX




        'MyResultCalc = a0 + MyInt16N : Console.WriteLine("a0 + MyInt16N = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MyInt32N : Console.WriteLine("a0 + MyInt32N = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MyInt64N : Console.WriteLine("a0 + MyInt64N = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MyDecN : Console.WriteLine("a0 + MyDecN = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MyDoubleN : Console.WriteLine("a0 + MyDoubleN = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MySingleN : Console.WriteLine("a0 + MySingleN = " & MyResultCalc.ToString)
        'MyResultCalc = a0 + MyBoolN : Console.WriteLine("a0 + MyBoolN = " & MyResultCalc.ToString)

        'MyResultCalc = MyInt16N + a0 : Console.WriteLine("MyInt16N + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyInt32N + a0 : Console.WriteLine("MyInt32N + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyInt64N + a0 : Console.WriteLine("MyInt64N + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyDecN + a0 : Console.WriteLine("MyDecN + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyDoubleN + a0 : Console.WriteLine("MyDoubleN + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MySingleN + a0 : Console.WriteLine("MySingleN + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyBoolN + a0 : Console.WriteLine("MyBoolN + a0 = " & MyResultCalc.ToString)

        'MyResultCalc = a0 - MyInt16N : Console.WriteLine("a0 - MyInt16N = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyInt32N : Console.WriteLine("a0 - MyInt32N = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyInt64N : Console.WriteLine("a0 - MyInt16N = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyDecN : Console.WriteLine("a0 - MyInt16N = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyDoubleN : Console.WriteLine("a0 - MyInt16N = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MySingleN : Console.WriteLine("a0 - MyInt16N = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyBoolN : Console.WriteLine("a0 - MyInt16N = " & MyResultCalc.ToString)

        'MyResultCalc = MyInt16N - a0 : Console.WriteLine("MyInt16N - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyInt32N - a0 : Console.WriteLine("MyInt32N - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyInt64N - a0 : Console.WriteLine("MyInt64N - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyDecN - a0 : Console.WriteLine("MyDecN - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyDoubleN - a0 : Console.WriteLine("MyDoubleN - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MySingleN - a0 : Console.WriteLine("MySingleN - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyBoolN - a0 : Console.WriteLine("MyInt16N - a0 = " & MyResultCalc.ToString)



        'MyResultCalc = a0 + MyInt16 : Console.WriteLine("a0 + MyInt16 = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MyInt32 : Console.WriteLine("a0 + MyInt32 = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MyInt64 : Console.WriteLine("a0 + MyInt64 = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MyDec : Console.WriteLine("a0 + MyDec = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MyDouble : Console.WriteLine("a0 + MyDouble = " & MyResultCalc.Value.ToString)
        'MyResultCalc = a0 + MySingle : Console.WriteLine("a0 + MySingle = " & MyResultCalc.ToString)
        'MyResultCalc = a0 + MyBool : Console.WriteLine("a0 + MyBool = " & MyResultCalc.ToString)

        'MyResultCalc = MyInt16 + a0 : Console.WriteLine("MyInt16 + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyInt32 + a0 : Console.WriteLine("MyInt32 + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyInt64 + a0 : Console.WriteLine("MyInt64 + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyDec + a0 : Console.WriteLine("MyDec + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyDouble + a0 : Console.WriteLine("MyDouble + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MySingle + a0 : Console.WriteLine("MySingle + a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyBool + a0 : Console.WriteLine("MyBool + a0 = " & MyResultCalc.ToString)

        'MyResultCalc = a0 - MyInt16 : Console.WriteLine("a0 - MyInt16 = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyInt32 : Console.WriteLine("a0 - MyInt16 = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyInt64 : Console.WriteLine("a0 - MyInt16 = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyDec : Console.WriteLine("a0 - MyInt16 = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyDouble : Console.WriteLine("a0 - MyInt16 = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MySingle : Console.WriteLine("a0 - MyInt16 = " & MyResultCalc.ToString)
        'MyResultCalc = a0 - MyBool : Console.WriteLine("a0 - MyInt16 = " & MyResultCalc.ToString)

        'MyResultCalc = MyInt16 - a0 : Console.WriteLine("MyInt16 - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyInt32 - a0 : Console.WriteLine("MyInt32 - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyInt64 - a0 : Console.WriteLine("MyInt64 - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyDec - a0 : Console.WriteLine("MyDec - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyDouble - a0 : Console.WriteLine("MyDouble - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MySingle - a0 : Console.WriteLine("MySingle - a0 = " & MyResultCalc.ToString)
        'MyResultCalc = MyBool - a0 : Console.WriteLine("MyInt16 - a0 = " & MyResultCalc.ToString)



        ' Stop

        'If c = d Then
        '    Stop
        'Else
        '    Stop
        'End If
    End Sub

End Module

