using CustomMvvmFormWithRecurrenceExample.Model;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.ObjectModel;

namespace CustomMvvmFormWithRecurrenceExample {
    public class MainViewModel {
        public virtual ObservableCollection<Doctor> Doctors { get; set; }
        public virtual ObservableCollection<MedicalAppointment> Appointments { get; set; }

        protected MainViewModel() {
            Doctors = new ObservableCollection<Doctor>();
            Appointments = new ObservableCollection<MedicalAppointment>();
            CreateDoctors();
            CreateAppointments();
        }

        public void InitNewAppointment() { }

        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }

        private void CreateDoctors() {
            Doctors.Add(Doctor.Create(Id:1,Name:"Stomatologist"));
            Doctors.Add(Doctor.Create(Id:2, Name:"Ophthalmologist"));
            Doctors.Add(Doctor.Create(Id:3, Name:"Surgeon"));
        }

        private void CreateAppointments() {
            Random rand = new Random(DateTime.Now.Millisecond);
            Appointments.Add(MedicalAppointment.Create(StartTime : DateTime.Now.Date.AddHours(10), EndTime : DateTime.Now.Date.AddHours(11), DoctorId : 1, Notes : "", Location : "101", PatientName : "Dave Murrel", InsuranceNumber : GenerateNineNumbers(rand), FirstVisit : true));
            Appointments.Add(MedicalAppointment.Create(StartTime : DateTime.Now.Date.AddDays(2).AddHours(15), EndTime : DateTime.Now.Date.AddDays(2).AddHours(16), DoctorId : 1, Notes : "", Location : "101", PatientName : "Mike Roller", InsuranceNumber : GenerateNineNumbers(rand), FirstVisit : true));

            Appointments.Add(MedicalAppointment.Create(StartTime : DateTime.Now.Date.AddDays(1).AddHours(11), EndTime : DateTime.Now.Date.AddDays(1).AddHours(12), DoctorId : 2, Notes : "", Location : "103", PatientName : "Bert Parkins", InsuranceNumber : GenerateNineNumbers(rand), FirstVisit : true));
            Appointments.Add(MedicalAppointment.Create(StartTime : DateTime.Now.Date.AddDays(2).AddHours(10), EndTime : DateTime.Now.Date.AddDays(2).AddHours(12), DoctorId : 2, Notes : "", Location : "103", PatientName : "Carl Lucas", InsuranceNumber : GenerateNineNumbers(rand), FirstVisit : false));

            Appointments.Add(MedicalAppointment.Create(StartTime : DateTime.Now.Date.AddHours(12), EndTime : DateTime.Now.Date.AddHours(13), DoctorId : 3, Notes : "Blood test results are required", Location : "104", PatientName : "Brad Barnes", InsuranceNumber : GenerateNineNumbers(rand), FirstVisit : false));
            Appointments.Add(MedicalAppointment.Create(StartTime : DateTime.Now.Date.AddDays(1).AddHours(14), EndTime : DateTime.Now.Date.AddDays(1).AddHours(15), DoctorId : 3, Notes : "", Location : "104", PatientName : "Richard Fisher", InsuranceNumber : GenerateNineNumbers(rand), FirstVisit : true));
        }

        private string GenerateNineNumbers(Random rand) {
            string result = "";
            for (int i = 0; i < 9; i++) {
                result += rand.Next(9).ToString();
            }
            return result;
        }
    }
}
