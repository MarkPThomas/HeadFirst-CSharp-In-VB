Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Dim misterCoffee As New CoffeeMaker()
        Dim oldToasty As New Oven()

        ' Method can take any class that inherits from appliance
        MonitorPower(misterCoffee)

        ' Array can take any class that inherits from appliance
        Dim kitchenWare(1) As Appliance
        kitchenWare(0) = misterCoffee
        kitchenWare(1) = oldToasty

        ' UPCAST: CoffeeMaker to Appliance
        ' When you have an appliance reference, you can ONLY access 
        ' the methods And properties that have to do with appliances.
        ' You CAN'T use the CoffeeMaker methods and properties through 
        ' an Appliance reference, even if you know it really Is one.
        Dim powerConsumer As Appliance = New CoffeeMaker

        ' DOWNCAST: Appliance to CoffeeMaker
        ' You can determine if the Appliance Is a CoffeeMaker using `Is`
        ' If so, you can downcast it back to access the CoffeeMaker
        ' properties & methods
        If (TypeOf powerConsumer Is CoffeeMaker) Then
            Dim javaJoe As CoffeeMaker = TryCast(powerConsumer, CoffeeMaker)
            javaJoe.MakeCoffee()

            ' In an incorrect downcast, the object returned is Nothing, so `Preheat` will not be called
            Dim foodWarmer As Oven = TryCast(powerConsumer, Oven)
            If Not IsNothing(foodWarmer) Then foodWarmer.Preheat()
        End If

        ' Three different references that point to the same object can
        ' acess different methods And properties, depending on the
        ' reference's type.

        ' Reference 1
        Dim misterToasty As New Oven()
        misterToasty.Preheat()

        ' Reference 2
        Dim cooker As ICooksFood
        If (TypeOf misterToasty Is ICooksFood) Then
            cooker = misterToasty   'Cast is implicit
        End If

        ' Reference 3
        If (TypeOf misterToasty Is Appliance) Then
            powerConsumer = misterToasty
            powerConsumer.ConsumePower()
        End If
    End Sub

    Public Sub MonitorPower(ByVal appliance As Appliance)
        ' Code to add data to a household power consumption database
    End Sub
End Module
