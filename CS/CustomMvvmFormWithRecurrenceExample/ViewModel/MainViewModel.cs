using CustomMvvmFormWithRecurrenceExample.Model;
using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace CustomMvvmFormWithRecurrenceExample {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<Doctor> Doctors { get; set; }
        public ObservableCollection<MedicalAppointment> Appointments { get; set; }

        public MainViewModel() {
            Doctors = new ObservableCollection<Doctor>();
            Appointments = new ObservableCollection<MedicalAppointment>();
            CreateDoctors();
            CreateAppointments();
        }

        public void InitNewAppointment() { }

        private void CreateDoctors() {
            Doctors.Add(new Doctor(id: 1, name: "Stomatologist"));
            Doctors.Add(new Doctor(id: 2, name: "Ophthalmologist"));
            Doctors.Add(new Doctor(id: 3, name: "Surgeon"));
        }

        private void CreateAppointments() {
            Random rand = new Random(DateTime.Now.Millisecond);
            Appointments.Add(new MedicalAppointment(startTime: DateTime.Now.Date.AddHours(10), endTime: DateTime.Now.Date.AddHours(11), doctorId: 1, notes: "", location: "101", patientName: "Dave Murrel", insuranceNumber: GenerateNineNumbers(rand), firstVisit: true));
            Appointments.Add(new MedicalAppointment(startTime: DateTime.Now.Date.AddDays(2).AddHours(15), endTime: DateTime.Now.Date.AddDays(2).AddHours(16), doctorId: 1, notes: "", location: "101", patientName: "Mike Roller", insuranceNumber: GenerateNineNumbers(rand), firstVisit: true));

            Appointments.Add(new MedicalAppointment(startTime: DateTime.Now.Date.AddDays(1).AddHours(11), endTime: DateTime.Now.Date.AddDays(1).AddHours(12), doctorId: 2, notes: "", location: "103", patientName: "Bert Parkins", insuranceNumber: GenerateNineNumbers(rand), firstVisit: true));
            Appointments.Add(new MedicalAppointment(startTime: DateTime.Now.Date.AddDays(2).AddHours(10), endTime: DateTime.Now.Date.AddDays(2).AddHours(12), doctorId: 2, notes: "", location: "103", patientName: "Carl Lucas", insuranceNumber: GenerateNineNumbers(rand), firstVisit: false));

            Appointments.Add(new MedicalAppointment(startTime: DateTime.Now.Date.AddHours(12), endTime: DateTime.Now.Date.AddHours(13), doctorId: 3, notes: "Blood test results are required", location: "104", patientName: "Brad Barnes", insuranceNumber: GenerateNineNumbers(rand), firstVisit: false));
            Appointments.Add(new MedicalAppointment(startTime: DateTime.Now.Date.AddDays(1).AddHours(14), endTime: DateTime.Now.Date.AddDays(1).AddHours(15), doctorId: 3, notes: "", location: "104", patientName: "Richard Fisher", insuranceNumber: GenerateNineNumbers(rand), firstVisit: true));
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
