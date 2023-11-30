Namespace CustomMvvmFormWithRecurrenceExample.Model

    Public Class MedicalAppointment

        Public Sub New(ByVal startTime As Date, ByVal endTime As Date, ByVal doctorId As Integer, ByVal notes As String, ByVal location As String, ByVal patientName As String, ByVal insuranceNumber As String, ByVal firstVisit As Boolean)
            Me.StartTime = startTime
            Me.EndTime = endTime
            Me.DoctorId = doctorId
            Me.Notes = notes
            Me.Location = location
            Me.PatientName = patientName
            Me.InsuranceNumber = insuranceNumber
            Me.FirstVisit = firstVisit
        End Sub

        Protected Sub New()
        End Sub

        Public Property Id As Integer

        Public Property AllDay As Boolean

        Public Property StartTime As Date

        Public Property EndTime As Date

        Public Property PatientName As String

        Public Property Notes As String

        Public Property Subject As String

        Public Property PaymentStateId As Integer

        Public Property IssueId As Integer

        Public Property Type As Integer

        Public Property Location As String

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String

        Public Property DoctorId As Integer?

        Public Property InsuranceNumber As String

        Public Property FirstVisit As Boolean
    End Class
End Namespace
