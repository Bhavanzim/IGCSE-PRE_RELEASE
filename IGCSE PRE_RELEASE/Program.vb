Imports System

Module Program
    ' DECLARATION OF DATA STRUCTURES AND VARIABLES
    Dim CarLicenceNumber1(20) As String
    Dim NamesOfVistors1(20) As String
    Dim AvailableParkingSpace1(20) As Boolean
    Dim CarLicenceNumber2(20) As String
    Dim NamesOfVistors2(20) As String
    Dim AvailableParkingSpace2(20) As Boolean
    Dim CarLicenceNumber3(20) As String
    Dim NamesOfVistors3(20) As String
    Dim AvailableParkingSpace3(20) As Boolean
    Dim CarLicenceNumber4(20) As String
    Dim NamesOfVistors4(20) As String
    Dim AvailableParkingSpace4(20) As Boolean
    Dim CarLicenceNumber5(20) As String
    Dim NamesOfVistors5(20) As String
    Dim AvailableParkingSpace5(20) As Boolean
    Dim CarLicenceNumber6(20) As String
    Dim NamesOfVistors6(20) As String
    Dim AvailableParkingSpace6(20) As Boolean
    Dim CarLicenceNumber7(20) As String
    Dim NamesOfVistors7(20) As String
    Dim AvailableParkingSpace7(20) As Boolean
    Dim CarLicenceNumber8(20) As String
    Dim NamesOfVistors8(20) As String
    Dim AvailableParkingSpace8(20) As Boolean
    Dim CarLicenceNumber9(20) As String
    Dim NamesOfVistors9(20) As String
    Dim AvailableParkingSpace9(20) As Boolean
    Dim CarLicenceNumber10(20) As String
    Dim NamesOfVistors10(20) As String
    Dim AvailableParkingSpace10(20) As Boolean
    Dim CarLicenceNumber11(20) As String
    Dim NamesOfVistors11(20) As String
    Dim AvailableParkingSpace11(20) As Boolean
    Dim CarLicenceNumber12(20) As String
    Dim NamesOfVistors12(20) As String
    Dim AvailableParkingSpace12(20) As Boolean
    Dim CarLicenceNumber13(20) As String
    Dim NamesOfVistors13(20) As String
    Dim AvailableParkingSpace13(20) As Boolean
    Dim CarLicenceNumber14(20) As String
    Dim NamesOfVistors14(20) As String
    Dim AvailableParkingSpace14(20) As Boolean
    Dim CarLicenceNumber15(20) As String
    Dim NamesOfVistors15(20) As String
    Dim AvailableParkingSpace15(20) As Boolean
    Dim CarLicenceNumber16(20) As String
    Dim NamesOfVistors16(20) As String
    Dim AvailableParkingSpace16(20) As Boolean
    Dim CarLicenceNumber17(20) As String
    Dim NamesOfVistors17(20) As String
    Dim AvailableParkingSpace17(20) As Boolean
    Dim CarLicenceNumber18(20) As String
    Dim NamesOfVistors18(20) As String
    Dim AvailableParkingSpace18(20) As Boolean
    Dim CarLicenceNumber19(20) As String
    Dim NamesOfVistors19(20) As String
    Dim AvailableParkingSpace19(20) As Boolean
    Dim CarLicenceNumber20(20) As String
    Dim NamesOfVistors20(20) As String
    Dim AvailableParkingSpace20(20) As Boolean
    Dim DayofReservation, CurrentDay As Integer
    Dim CarLicenceCounter1, NameCounter1, Counter1 As Integer
    Dim CarLicenceCounter2, NameCounter2, Counter2 As Integer
    Dim CarLicenceCounter3, NameCounter3, Counter3 As Integer
    Dim CarLicenceCounter4, NameCounter4, Counter4 As Integer
    Dim CarLicenceCounter5, NameCounter5, Counter5 As Integer
    Dim CarLicenceCounter6, NameCounter6, Counter6 As Integer
    Dim CarLicenceCounter7, NameCounter7, Counter7 As Integer
    Dim CarLicenceCounter8, NameCounter8, Counter8 As Integer
    Dim CarLicenceCounter9, NameCounter9, Counter9 As Integer
    Dim CarLicenceCounter10, NameCounter10, Counter10 As Integer
    Dim CarLicenceCounter11, NameCounter11, Counter11 As Integer
    Dim CarLicenceCounter12, NameCounter12, Counter12 As Integer
    Dim CarLicenceCounter13, NameCounter13, Counter13 As Integer
    Dim CarLicenceCounter14, NameCounter14, Counter14 As Integer
    Dim CarLicenceCounter15, NameCounter15, Counter15 As Integer
    Dim CarLicenceCounter16, NameCounter16, Counter16 As Integer
    Dim CarLicenceCounter17, NameCounter17, Counter17 As Integer
    Dim CarLicenceCounter18, NameCounter18, Counter18 As Integer
    Dim CarLicenceCounter19, NameCounter19, Counter19 As Integer
    Dim CarLicenceCounter20, NameCounter20, Counter20 As Integer

    Sub Main(args As String())
        'INITIALIZATION
        CarLicenceCounter1 = 1
        NameCounter1 = 1
        Counter1 = 1

        CarLicenceCounter2 = 1
        NameCounter2 = 1
        Counter2 = 1

        CarLicenceCounter3 = 1
        NameCounter3 = 1
        Counter3 = 1

        CarLicenceCounter4 = 1
        NameCounter4 = 1
        Counter4 = 1

        CarLicenceCounter5 = 1
        NameCounter5 = 1
        Counter5 = 1

        CarLicenceCounter6 = 1
        NameCounter6 = 1
        Counter6 = 1

        CarLicenceCounter7 = 1
        NameCounter7 = 1
        Counter7 = 1

        CarLicenceCounter8 = 1
        NameCounter8 = 1
        Counter8 = 1

        CarLicenceCounter9 = 1
        NameCounter9 = 1
        Counter9 = 1

        CarLicenceCounter10 = 1
        NameCounter10 = 1
        Counter10 = 1

        CarLicenceCounter11 = 1
        NameCounter11 = 1
        Counter11 = 1

        CarLicenceCounter12 = 1
        NameCounter12 = 1
        Counter12 = 1

        CarLicenceCounter13 = 1
        NameCounter13 = 1
        Counter13 = 1

        CarLicenceCounter14 = 1
        NameCounter14 = 1
        Counter14 = 1

        CarLicenceCounter15 = 1
        NameCounter15 = 1
        Counter15 = 1

        CarLicenceCounter16 = 1
        NameCounter16 = 1
        Counter16 = 1

        CarLicenceCounter17 = 1
        NameCounter17 = 1
        Counter17 = 1

        CarLicenceCounter18 = 1
        NameCounter18 = 1
        Counter18 = 1

        CarLicenceCounter19 = 1
        NameCounter19 = 1
        Counter19 = 1

        CarLicenceCounter20 = 1
        NameCounter20 = 1
        Counter20 = 1

        ' INPUT
        Console.WriteLine("Please enter the desired day you wish to reserve a parking space")
        DayofReservation = Console.ReadLine
        Console.WriteLine("Please enter the current day")
        CurrentDay = Console.ReadLine

        ' CLEARING OF DATA FOR NEXT 14 DAY PERIOD
        If CurrentDay = 14 Then
            For x = 1 To 20
                CarLicenceNumber1(x) = 20
                NamesOfVistors1(x) = 20
                AvailableParkingSpace1(x) = True
                CarLicenceNumber2(x) = 20
                NamesOfVistors2(x) = 20
                AvailableParkingSpace2(x) = True
                CarLicenceNumber3(x) = 20
                NamesOfVistors3(x) = 20
                AvailableParkingSpace3(x) = True
                CarLicenceNumber4(x) = 20
                NamesOfVistors4(x) = 20
                AvailableParkingSpace4(x) = True
                CarLicenceNumber5(x) = 20
                NamesOfVistors5(x) = 20
                AvailableParkingSpace5(x) = True
                CarLicenceNumber6(x) = 20
                NamesOfVistors6(x) = 20
                AvailableParkingSpace6(x) = True
                CarLicenceNumber7(x) = 20
                NamesOfVistors7(x) = 20
                AvailableParkingSpace7(x) = True
                CarLicenceNumber8(x) = 20
                NamesOfVistors8(x) = 20
                AvailableParkingSpace8(x) = True
                CarLicenceNumber9(x) = 20
                NamesOfVistors9(x) = 20
                AvailableParkingSpace9(x) = True
                CarLicenceNumber10(x) = 20
                NamesOfVistors10(x) = 20
                AvailableParkingSpace10(x) = True
                CarLicenceNumber11(x) = 20
                NamesOfVistors11(x) = 20
                AvailableParkingSpace11(x) = True
                CarLicenceNumber12(x) = 20
                NamesOfVistors12(x) = 20
                AvailableParkingSpace12(x) = True
                CarLicenceNumber13(x) = 20
                NamesOfVistors13(x) = 20
                AvailableParkingSpace13(x) = True
                CarLicenceNumber14(x) = 20
                NamesOfVistors14(x) = 20
                AvailableParkingSpace14(x) = True
                CarLicenceNumber15(x) = 20
                NamesOfVistors15(x) = 20
                AvailableParkingSpace15(x) = True
                CarLicenceNumber16(x) = 20
                NamesOfVistors16(x) = 20
                AvailableParkingSpace16(x) = True
                CarLicenceNumber17(x) = 20
                NamesOfVistors17(x) = 20
                AvailableParkingSpace17(x) = True
                CarLicenceNumber18(x) = 20
                NamesOfVistors18(x) = 20
                AvailableParkingSpace18(x) = True
                CarLicenceNumber19(x) = 20
                NamesOfVistors19(x) = 20
                AvailableParkingSpace19(x) = True
                CarLicenceNumber20(x) = 20
                NamesOfVistors20(x) = 20
                AvailableParkingSpace20(x) = True
            Next
        End If

        For x = 1 To 20
            CarLicenceNumber1(x) = 20
            NamesOfVistors1(x) = 20
            AvailableParkingSpace1(x) = True
            CarLicenceNumber2(x) = 20
            NamesOfVistors2(x) = 20
            AvailableParkingSpace2(x) = True
            CarLicenceNumber3(x) = 20
            NamesOfVistors3(x) = 20
            AvailableParkingSpace3(x) = True
            CarLicenceNumber4(x) = 20
            NamesOfVistors4(x) = 20
            AvailableParkingSpace4(x) = True
            CarLicenceNumber5(x) = 20
            NamesOfVistors5(x) = 20
            AvailableParkingSpace5(x) = True
            CarLicenceNumber6(x) = 20
            NamesOfVistors6(x) = 20
            AvailableParkingSpace6(x) = True
            CarLicenceNumber7(x) = 20
            NamesOfVistors7(x) = 20
            AvailableParkingSpace7(x) = True
            CarLicenceNumber8(x) = 20
            NamesOfVistors8(x) = 20
            AvailableParkingSpace8(x) = True
            CarLicenceNumber9(x) = 20
            NamesOfVistors9(x) = 20
            AvailableParkingSpace9(x) = True
            CarLicenceNumber10(x) = 20
            NamesOfVistors10(x) = 20
            AvailableParkingSpace10(x) = True
            CarLicenceNumber11(x) = 20
            NamesOfVistors11(x) = 20
            AvailableParkingSpace11(x) = True
            CarLicenceNumber12(x) = 20
            NamesOfVistors12(x) = 20
            AvailableParkingSpace12(x) = True
            CarLicenceNumber13(x) = 20
            NamesOfVistors13(x) = 20
            AvailableParkingSpace13(x) = True
            CarLicenceNumber14(x) = 20
            NamesOfVistors14(x) = 20
            AvailableParkingSpace14(x) = True
            CarLicenceNumber15(x) = 20
            NamesOfVistors15(x) = 20
            AvailableParkingSpace15(x) = True
            CarLicenceNumber16(x) = 20
            NamesOfVistors16(x) = 20
            AvailableParkingSpace16(x) = True
            CarLicenceNumber17(x) = 20
            NamesOfVistors17(x) = 20
            AvailableParkingSpace17(x) = True
            CarLicenceNumber18(x) = 20
            NamesOfVistors18(x) = 20
            AvailableParkingSpace18(x) = True
            CarLicenceNumber19(x) = 20
            NamesOfVistors19(x) = 20
            AvailableParkingSpace19(x) = True
            CarLicenceNumber20(x) = 20
            NamesOfVistors20(x) = 20
            AvailableParkingSpace20(x) = True
        Next
        ' VALIDATION OF DAY

        While DayofReservation > 14 And DayofReservation < 0
            Console.WriteLine("Invalid Day, please enter a number 1 to 14")
            DayofReservation = Console.ReadLine
        End While

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace1(Counter1) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors1(NameCounter1) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber1(CarLicenceCounter1) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter1)
                        NameCounter1 = NameCounter1 + 1
                        CarLicenceCounter1 = CarLicenceCounter1 + 1
                        Counter1 = Counter1 + 1
                        Exit For
                    End If
                    Counter1 = Counter1 + 1
                Loop Until Counter1 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace2(Counter2) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors2(NameCounter2) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber2(CarLicenceCounter2) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter2)
                        NameCounter2 = NameCounter2 + 1
                        CarLicenceCounter2 = CarLicenceCounter2 + 1
                        Counter2 = Counter2 + 1
                        Exit For
                    End If
                    Counter2 = Counter2 + 1
                Loop Until Counter2 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace3(Counter3) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors3(NameCounter3) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber3(CarLicenceCounter3) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter3)
                        NameCounter3 = NameCounter3 + 1
                        CarLicenceCounter3 = CarLicenceCounter3 + 1
                        Counter3 = Counter3 + 1
                        Exit For
                    End If
                    Counter3 = Counter3 + 1
                Loop Until Counter3 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace4(Counter4) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors4(NameCounter4) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber4(CarLicenceCounter4) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter4)
                        NameCounter4 = NameCounter4 + 1
                        CarLicenceCounter4 = CarLicenceCounter4 + 1
                        Counter4 = Counter4 + 1
                        Exit For
                    End If
                    Counter4 = Counter4 + 1
                Loop Until Counter4 = 20
            End If
        Next
        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace5(Counter5) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors5(NameCounter5) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber5(CarLicenceCounter5) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter5)
                        NameCounter5 = NameCounter5 + 1
                        CarLicenceCounter5 = CarLicenceCounter5 + 1
                        Counter5 = Counter5 + 1
                        Exit For
                    End If
                    Counter5 = Counter5 + 1
                Loop Until Counter5 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace6(Counter6) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors6(NameCounter6) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber6(CarLicenceCounter6) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter6)
                        NameCounter6 = NameCounter6 + 1
                        CarLicenceCounter6 = CarLicenceCounter6 + 1
                        Counter6 = Counter6 + 1
                        Exit For
                    End If
                    Counter6 = Counter6 + 1
                Loop Until Counter6 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace7(Counter7) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors7(NameCounter7) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber7(CarLicenceCounter7) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter7)
                        NameCounter7 = NameCounter7 + 1
                        CarLicenceCounter7 = CarLicenceCounter7 + 1
                        Counter7 = Counter7 + 1
                        Exit For
                    End If
                    Counter7 = Counter7 + 1
                Loop Until Counter7 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace8(Counter8) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors8(NameCounter8) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber8(CarLicenceCounter8) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter8)
                        NameCounter8 = NameCounter8 + 1
                        CarLicenceCounter8 = CarLicenceCounter8 + 1
                        Counter8 = Counter8 + 1
                        Exit For
                    End If
                    Counter8 = Counter8 + 1
                Loop Until Counter8 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace9(Counter9) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors9(NameCounter9) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber9(CarLicenceCounter9) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter9)
                        NameCounter9 = NameCounter9 + 1
                        CarLicenceCounter9 = CarLicenceCounter9 + 1
                        Counter9 = Counter9 + 1
                        Exit For
                    End If
                    Counter9 = Counter9 + 1
                Loop Until Counter9 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace10(Counter10) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors10(NameCounter10) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber10(CarLicenceCounter10) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter10)
                        NameCounter10 = NameCounter10 + 1
                        CarLicenceCounter10 = CarLicenceCounter10 + 1
                        Counter10 = Counter10 + 1
                        Exit For
                    End If
                    Counter10 = Counter10 + 1
                Loop Until Counter10 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace10(Counter11) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors11(NameCounter11) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber11(CarLicenceCounter11) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter11)
                        NameCounter11 = NameCounter11 + 1
                        CarLicenceCounter11 = CarLicenceCounter11 + 1
                        Counter11 = Counter11 + 1
                        Exit For
                    End If
                    Counter11 = Counter11 + 1
                Loop Until Counter11 = 20
            End If
        Next
        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace12(Counter12) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors12(NameCounter12) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber12(CarLicenceCounter12) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter12)
                        NameCounter12 = NameCounter12 + 1
                        CarLicenceCounter12 = CarLicenceCounter12 + 1
                        Counter12 = Counter12 + 1
                        Exit For
                    End If
                    Counter12 = Counter12 + 1
                Loop Until Counter12 = 20
            End If
        Next
        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace13(Counter13) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors13(NameCounter13) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber13(CarLicenceCounter13) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter13)
                        NameCounter13 = NameCounter13 + 1
                        CarLicenceCounter13 = CarLicenceCounter13 + 1
                        Counter13 = Counter13 + 1
                        Exit For
                    End If
                    Counter13 = Counter13 + 1
                Loop Until Counter13 = 20
            End If
        Next
        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace14(Counter14) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors14(NameCounter14) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber14(CarLicenceCounter14) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter14)
                        NameCounter14 = NameCounter14 + 1
                        CarLicenceCounter14 = CarLicenceCounter14 + 1
                        Counter14 = Counter14 + 1
                        Exit For
                    End If
                    Counter14 = Counter14 + 1
                Loop Until Counter14 = 20
            End If
        Next
        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace15(Counter15) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors15(NameCounter15) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber15(CarLicenceCounter15) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter15)
                        NameCounter15 = NameCounter15 + 1
                        CarLicenceCounter15 = CarLicenceCounter15 + 1
                        Counter15 = Counter15 + 1
                        Exit For
                    End If
                    Counter15 = Counter15 + 1
                Loop Until Counter15 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace16(Counter16) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors16(NameCounter16) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber16(CarLicenceCounter16) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter16)
                        NameCounter16 = NameCounter16 + 1
                        CarLicenceCounter16 = CarLicenceCounter16 + 1
                        Counter16 = Counter16 + 1
                        Exit For
                    End If
                    Counter16 = Counter16 + 1
                Loop Until Counter16 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace17(Counter17) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors17(NameCounter17) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber17(CarLicenceCounter17) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter17)
                        NameCounter17 = NameCounter17 + 1
                        CarLicenceCounter17 = CarLicenceCounter17 + 1
                        Counter17 = Counter17 + 1
                        Exit For
                    End If
                    Counter17 = Counter17 + 1
                Loop Until Counter17 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace18(Counter18) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors18(NameCounter18) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber18(CarLicenceCounter18) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter18)
                        NameCounter18 = NameCounter18 + 1
                        CarLicenceCounter18 = CarLicenceCounter18 + 1
                        Counter18 = Counter18 + 1
                        Exit For
                    End If
                    Counter18 = Counter18 + 1
                Loop Until Counter18 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace19(Counter19) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors19(NameCounter19) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber19(CarLicenceCounter19) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter19)
                        NameCounter19 = NameCounter19 + 1
                        CarLicenceCounter19 = CarLicenceCounter19 + 1
                        Counter19 = Counter19 + 1
                        Exit For
                    End If
                    Counter19 = Counter19 + 1
                Loop Until Counter19 = 20
            End If
        Next

        For x = 1 To 14
            If DayofReservation = x Then
                Do
                    If AvailableParkingSpace20(Counter20) = True Then
                        Console.WriteLine("Please Enter Your Name")
                        NamesOfVistors20(NameCounter20) = Console.ReadLine
                        Console.WriteLine("Please Enter you Car Licence Number")
                        CarLicenceNumber20(CarLicenceCounter20) = Console.ReadLine
                        Console.WriteLine("Your Parking Space is {0}", Counter17)
                        NameCounter20 = NameCounter20 + 1
                        CarLicenceCounter20 = CarLicenceCounter20 + 1
                        Counter20 = Counter20 + 1
                        Exit For
                    End If
                    Counter20 = Counter20 + 1
                Loop Until Counter20 = 20
            End If
        Next

        Console.ReadLine()
    End Sub
End Module
