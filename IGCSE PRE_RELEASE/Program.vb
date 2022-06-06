Imports System

Module Program
    ' DECLARATION OF DATA STRUCTURES AND VARIABLES
    Dim CarLicenceNumber(20) As Integer
    Dim NamesOfVistors(20) As String
    Dim AvailableParkingSpace(20) As Boolean
    Dim DayofReservation, CurrentDay, CarLicenceCounter, NameCounter, Counter As Integer

    Sub Main(args As String())
        'INITIALIZATION
        CarLicenceCounter = 1
        NameCounter = 1
        Counter = 1
        ' INPUT
        Console.WriteLine("Please enter the desired day you wish to reserve a parking space")
        DayofReservation = Console.ReadLine
        Console.WriteLine("Please enter the current day")
        CurrentDay = Console.ReadLine
        ' CLEARING OF DATA FOR NEXT 14 DAY PERIOD
        If CurrentDay = 14 Then
            For x = 1 To 20
                CarLicenceNumber(x) = 20
                NamesOfVistors(x) = 20
                AvailableParkingSpace(x) = True
            Next
        End If

        For x = 1 To 20
            CarLicenceNumber(x) = 20
            NamesOfVistors(x) = 20
            AvailableParkingSpace(x) = True
        Next
        ' VALIDATION OF DAY
        While DayofReservation > 14 And DayofReservation < 0
            Console.WriteLine("Invalid Day, please enter a number 1 to 14")
            DayofReservation = Console.ReadLine
        End While

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace(Counter) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors(NameCounter) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber(CarLicenceCounter) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter)
                        NameCounter = NameCounter + 1
                        CarLicenceCounter = CarLicenceCounter + 1
                        Counter = Counter + 1
                        Exit For
                    End If
                    Counter = Counter + 1
                Loop Until Counter = 20
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
