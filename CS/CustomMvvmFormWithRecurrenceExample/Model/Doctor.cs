using DevExpress.Mvvm.POCO;

namespace CustomMvvmFormWithRecurrenceExample {
    public class Doctor {
        public static Doctor Create() {
            return ViewModelSource.Create(() => new Doctor());
        }
        public static Doctor Create(int Id, string Name) {
            Doctor doctor = Doctor.Create();
            doctor.Id = Id;
            doctor.Name = Name;
            return doctor;
        }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
