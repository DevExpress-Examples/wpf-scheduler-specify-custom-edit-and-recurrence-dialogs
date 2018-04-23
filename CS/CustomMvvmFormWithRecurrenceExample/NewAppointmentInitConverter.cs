#region #NewAppointmentInitConverter
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Scheduling;

namespace CustomMvvmFormWithRecurrenceExample {
    public class NewAppointmentInitConverter : EventArgsConverterBase<AppointmentItemEventArgs> {
        protected override object Convert(object sender, AppointmentItemEventArgs args) {
            args.Appointment.LabelKey = 1;
            args.Appointment.Reminders.Clear();
            return args;
        }
    }
}
#endregion #NewAppointmentInitConverter
