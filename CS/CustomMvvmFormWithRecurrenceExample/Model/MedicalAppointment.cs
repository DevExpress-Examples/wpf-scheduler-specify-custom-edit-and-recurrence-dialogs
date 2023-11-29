using System;

namespace CustomMvvmFormWithRecurrenceExample.Model {
    public class MedicalAppointment {
        public MedicalAppointment(DateTime startTime, DateTime endTime, int doctorId, string notes, string location, string patientName, string insuranceNumber, bool firstVisit) {
            StartTime = startTime;
            EndTime = endTime;
            DoctorId = doctorId;
            Notes = notes;
            Location = location;
            PatientName = patientName;
            InsuranceNumber = insuranceNumber;
            FirstVisit = firstVisit;
        }

        protected MedicalAppointment() { }
        public int Id { get; set; }
        public bool AllDay { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string PatientName { get; set; }
        public string Notes { get; set; }
        public string Subject { get; set; }
        public int PaymentStateId { get; set; }
        public int IssueId { get; set; }
        public int Type { get; set; }
        public string Location { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public int? DoctorId { get; set; }
        public string InsuranceNumber { get; set; }
        public bool FirstVisit { get; set; }
    }
}
