Imports CustomMvvmFormWithRecurrenceExample.Model
Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel

Namespace CustomMvvmFormWithRecurrenceExample

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Doctors As ObservableCollection(Of Doctor)

        Public Property Appointments As ObservableCollection(Of MedicalAppointment)

        Public Sub New()
            Doctors = New ObservableCollection(Of Doctor)()
            Appointments = New ObservableCollection(Of MedicalAppointment)()
            CreateDoctors()
            CreateAppointments()
        End Sub

        Public Sub InitNewAppointment()
        End Sub

        Private Sub CreateDoctors()
            Doctors.Add(New Doctor(id:=1, name:="Stomatologist"))
            Doctors.Add(New Doctor(id:=2, name:="Ophthalmologist"))
            Doctors.Add(New Doctor(id:=3, name:="Surgeon"))
        End Sub

        Private Sub CreateAppointments()
            Dim rand As Random = New Random(Date.Now.Millisecond)
            Appointments.Add(New MedicalAppointment(startTime:=Date.Now.Date.AddHours(10), endTime:=Date.Now.Date.AddHours(11), doctorId:=1, notes:="", location:="101", patientName:="Dave Murrel", insuranceNumber:=GenerateNineNumbers(rand), firstVisit:=True))
            Appointments.Add(New MedicalAppointment(startTime:=Date.Now.Date.AddDays(2).AddHours(15), endTime:=Date.Now.Date.AddDays(2).AddHours(16), doctorId:=1, notes:="", location:="101", patientName:="Mike Roller", insuranceNumber:=GenerateNineNumbers(rand), firstVisit:=True))
            Appointments.Add(New MedicalAppointment(startTime:=Date.Now.Date.AddDays(1).AddHours(11), endTime:=Date.Now.Date.AddDays(1).AddHours(12), doctorId:=2, notes:="", location:="103", patientName:="Bert Parkins", insuranceNumber:=GenerateNineNumbers(rand), firstVisit:=True))
            Appointments.Add(New MedicalAppointment(startTime:=Date.Now.Date.AddDays(2).AddHours(10), endTime:=Date.Now.Date.AddDays(2).AddHours(12), doctorId:=2, notes:="", location:="103", patientName:="Carl Lucas", insuranceNumber:=GenerateNineNumbers(rand), firstVisit:=False))
            Appointments.Add(New MedicalAppointment(startTime:=Date.Now.Date.AddHours(12), endTime:=Date.Now.Date.AddHours(13), doctorId:=3, notes:="Blood test results are required", location:="104", patientName:="Brad Barnes", insuranceNumber:=GenerateNineNumbers(rand), firstVisit:=False))
            Appointments.Add(New MedicalAppointment(startTime:=Date.Now.Date.AddDays(1).AddHours(14), endTime:=Date.Now.Date.AddDays(1).AddHours(15), doctorId:=3, notes:="", location:="104", patientName:="Richard Fisher", insuranceNumber:=GenerateNineNumbers(rand), firstVisit:=True))
        End Sub

        Private Function GenerateNineNumbers(ByVal rand As Random) As String
            Dim result As String = ""
            For i As Integer = 0 To 9 - 1
                result += rand.Next(9).ToString()
            Next

            Return result
        End Function
    End Class
End Namespace
