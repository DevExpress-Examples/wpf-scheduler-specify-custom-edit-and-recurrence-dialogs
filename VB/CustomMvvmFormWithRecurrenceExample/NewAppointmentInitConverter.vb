#Region "#NewAppointmentInitConverter"
Imports DevExpress.Mvvm.UI
Imports DevExpress.Xpf.Scheduling

Namespace CustomMvvmFormWithRecurrenceExample
    Public Class NewAppointmentInitConverter
        Inherits EventArgsConverterBase(Of AppointmentItemEventArgs)

        Protected Overrides Function Convert(ByVal sender As Object, ByVal args As AppointmentItemEventArgs) As Object
            args.Appointment.LabelId = 1
            args.Appointment.Reminders.Clear()
            Return args
        End Function
    End Class
End Namespace
#End Region ' #NewAppointmentInitConverter
