using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");
            Hospital hospital = new Hospital();

            Doctor doctor1 = new Doctor(1, "Іванов Іван", "Кардіолог");
            hospital.AddDoctor(doctor1);
            Doctor doctor2 = new Doctor(2, "Петренко Марія", "Хірург");
            hospital.AddDoctor(doctor2);

            Patient pat1 = new Patient(1, "Федор", 22);
            hospital.RegisterPatient(pat1);
            Patient pat2 = new Patient(2, "Ваня", 23);
            hospital.RegisterPatient(pat2);
            Patient pat3 = new Patient(3, "Коля", 24);
            hospital.RegisterPatient(pat3);
            Patient pat4 = new Patient(4, "Андрюха", 25);
            hospital.RegisterPatient(pat4);
            HospitalRoom room1 = new HospitalRoom(202, 2);
            HospitalRoom room2 = new HospitalRoom(103, 2);
            hospital.CreateRoom(room1);
            hospital.CreateRoom(room2);

            hospital.HospitalizePatient(1, 202);
            hospital.HospitalizePatient(2, 202);
            hospital.HospitalizePatient(3, 103);
            hospital.HospitalizePatient(4, 103);

            hospital.AddMedicalRecord(new MedicalRecord(pat1, doctor1, DateTime.Now, "Планове обстеження серця. Тиск в нормі."));
            hospital.AddMedicalRecord(new MedicalRecord(pat2, doctor2, DateTime.Now, "Консультація щодо операції на апендицит."));
            hospital.AddMedicalRecord(new MedicalRecord(pat3, doctor1, new DateTime(2025, 10, 8), "Скарги на біль у грудях. Призначено ЕКГ."));
            hospital.AddMedicalRecord(new MedicalRecord(pat4, doctor2, new DateTime(2025, 10, 7), "Перелом лівої руки. Накладено гіпс."));

            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            Console.WriteLine(hospital.GetStatistics());






        }
    }
}
