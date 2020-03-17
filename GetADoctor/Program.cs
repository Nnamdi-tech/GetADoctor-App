using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetADoctor 
{ 

    class Doctor
    {
        public String _FullName { get; set; }
        public int _Age { get; set; }
        public String _Qualification { get; set; }
        public int _Experience { get; set; }
        public String _Specialization { get; set; }
        public String _Gender { get; set; }
        public int _PhoneNumber { get; set; }
        public String _EMail { get; set; }
        public String _Address { get; set; }

        public Doctor(string name, int age, string qual, int exp, string spec, string gender, int phone, string mail, string add)
        {
            this._FullName = name;
            this._Age = age;
            this._Qualification = qual;
            this._Experience = exp;
            this._Specialization = spec;
            this._Gender = gender;
            this._PhoneNumber = phone;
            this._EMail = mail;
            this._Address = add;

        }


    }
    class Patient
    {
        public string _FullName { get; set; }
        int _Age { get; set; }
        public string _BloodGroup { get; set; }
        public string _Genotype { get; set; }
        public string _Gender { get; set; }
        public int _PhoneNumber { get; set; }
        public string _EMail { get; set; }
        public String _Address { get; set; }

        public Patient(string name, int age, string bg, string gnt, string gender, int phone, string mail, string add)
        {
            this._FullName = name;
            this._Age = age;
            this._BloodGroup = bg;
            this._Genotype = gnt;
            this._Gender = gender;
            this._PhoneNumber = phone;
            this._EMail = mail;
            this._Address = add;

        }

    }

    class Appointment
    {
        public int ID { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string AppointDate { get; set; }
        public string AppointTime { get; set; }

        public Appointment(int id, string doctorName, string patientName, string appointDate, string appointTime)
        {
            this.ID = id;
            this.DoctorName = doctorName;
            this.PatientName = patientName;
            this.AppointDate = appointDate;
            this.AppointTime = appointTime;
        }


    }
    class DoctorManager : IDoctorManager
    {
       public List<Doctor> doclist = new List<Doctor>();
       public List<Patient> patlist = new List<Patient>();
       public List<Appointment> Apptlist = new List<Appointment>();
        public void DoctorsRecord(Doctor doctorslist)
        {
            
            doclist.Add(doctorslist);
        }
        public void PatientsRecord(Patient patientslist)
        {
            patlist.Add(patientslist);
        }
        public void add(Doctor d)
        {
            doclist.Add(d);
        }

        public void add(Patient P)
        {
            throw new NotImplementedException();
        }
        public void add(Appointment A)
        {
            Apptlist.Add(A);
        }
        public void remove(Appointment A)
        {
            throw new NotImplementedException();
        }
        public void update(Appointment A)
        {
            throw new NotImplementedException();
        }

        public void remove(Doctor d)
        {
            throw new NotImplementedException();
        }

        public void remove(Patient P)
        {
            throw new NotImplementedException();
        }

        public void update(Doctor d)
        {
            throw new NotImplementedException();
        }

        public void update(Patient P)
        {
            throw new NotImplementedException();
        }
    }

    interface IDoctorManager
    {
        void add(Doctor d);
        void remove(Doctor d);
        void update(Doctor d);
        void add(Patient P);
        void remove(Patient P);
        void update(Patient P);
        void add(Appointment A);
        void remove(Appointment A);
        void update(Appointment A);
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());

            //Doctor chi = new Doctor("Chigozie", 40, "MBBS", 5, "guy", "M", 090, "mb.com", "kotopo Abeokuta");
            //Console.WriteLine("Baby Boy");
        }

        public static DoctorManager finalManage = new DoctorManager();
    }
}
