Imports CustomMvvmFormWithRecurrenceExample.Model
Imports DevExpress.Mvvm.POCO
Imports System
Imports System.Collections.ObjectModel

Namespace CustomMvvmFormWithRecurrenceExample
    Public Class MainViewModel
        Public Overridable Property Doctors() As ObservableCollection(Of Doctor)
        Public Overridable Property Appointments() As ObservableCollection(Of MedicalAppointment)

        Protected Sub New()
            Doctors = New ObservableCollection(Of Doctor)()
            Appointments = New ObservableCollection(Of MedicalAppointment)()
            CreateDoctors()
            CreateAppointments()
        End Sub

        Public Sub InitNewAppointment()
        End Sub

        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function

        Private Sub CreateDoctors()
            Doctors.Add(Doctor.Create(Id:=1,Name:="Stomatologist"))
            Doctors.Add(Doctor.Create(Id:=2, Name:="Ophthalmologist"))
            Doctors.Add(Doctor.Create(Id:=3, Name:="Surgeon"))
        End Sub

        Private Sub CreateAppointments()
            Dim rand As New Random(Date.Now.Millisecond)
            Appointments.Add(MedicalAppointment.Create(StartTime := Date.Now.Date.AddHours(10), EndTime := Date.Now.Date.AddHours(11), DoctorId := 1, Notes := "", Location := "101", PatientName := "Dave Murrel", InsuranceNumber := GenerateNineNumbers(rand), FirstVisit := True))
            Appointments.Add(MedicalAppointment.Create(StartTime := Date.Now.Date.AddDays(2).AddHours(15), EndTime := Date.Now.Date.AddDays(2).AddHours(16), DoctorId := 1, Notes := "", Location := "101", PatientName := "Mike Roller", InsuranceNumber := GenerateNineNumbers(rand), FirstVisit := True))

            Appointments.Add(MedicalAppointment.Create(StartTime := Date.Now.Date.AddDays(1).AddHours(11), EndTime := Date.Now.Date.AddDays(1).AddHours(12), DoctorId := 2, Notes := "", Location := "103", PatientName := "Bert Parkins", InsuranceNumber := GenerateNineNumbers(rand), FirstVisit := True))
            Appointments.Add(MedicalAppointment.Create(StartTime := Date.Now.Date.AddDays(2).AddHours(10), EndTime := Date.Now.Date.AddDays(2).AddHours(12), DoctorId := 2, Notes := "", Location := "103", PatientName := "Carl Lucas", InsuranceNumber := GenerateNineNumbers(rand), FirstVisit := False))

            Appointments.Add(MedicalAppointment.Create(StartTime := Date.Now.Date.AddHours(12), EndTime := Date.Now.Date.AddHours(13), DoctorId := 3, Notes := "Blood test results are required", Location := "104", PatientName := "Brad Barnes", InsuranceNumber := GenerateNineNumbers(rand), FirstVisit := False))
            Appointments.Add(MedicalAppointment.Create(StartTime := Date.Now.Date.AddDays(1).AddHours(14), EndTime := Date.Now.Date.AddDays(1).AddHours(15), DoctorId := 3, Notes := "", Location := "104", PatientName := "Richard Fisher", InsuranceNumber := GenerateNineNumbers(rand), FirstVisit := True))
        End Sub

        Private Function GenerateNineNumbers(ByVal rand As Random) As String
            Dim result As String = ""
            For i As Integer = 0 To 8
                result &= rand.Next(9).ToString()
            Next i
            Return result
        End Function
    End Class
End Namespace
