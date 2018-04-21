using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    public class Program
    {
        public AppointmentList Go()
        {
            MedicalHistory medicalHistory = new MedicalHistory("sdfdsd", "dsfdsfds", true);
            InsuranceDetail insuranceDetail = new InsuranceDetail("3434343", "fdgfdgfd", "23/10/1234", "sdfdd");
            Paitent paitent = new Paitent("John","Doe","aa@aa.com",567890,"nothin", medicalHistory, insuranceDetail
                );
            Doctor doctor = new Doctor("Doctor","dsfdsfds","343@dfds.com",324455);
            Appointment appointment = new Appointment(paitent,"23:10",doctor,"23/10/1992","dsfsdfdsfsd");

            MedicalHistory medicalHistory1 = new MedicalHistory("sdfdsd", "dsfdsfds", true);
            InsuranceDetail insuranceDetail1 = new InsuranceDetail("3434343", "fdgfdgfd", "23/10/1234", "sdfdd");
            Paitent paitent1 = new Paitent("John", "Doe", "aa@aa.com", 567890, "nothin", medicalHistory1, insuranceDetail1
                );
            Doctor doctor1 = new Doctor("dfsdsfsd", "dsfdsfds", "343@dfds.com", 324455);
            Appointment appointment1 = new Appointment(paitent1, "20:10", doctor1, "23/10/1992", "dsfsdfdsfsd");

            MedicalHistory medicalHistory2 = new MedicalHistory("sdfdsd", "dsfdsfds", true);
            InsuranceDetail insuranceDetail2 = new InsuranceDetail("3434343", "fdgfdgfd", "23/10/1234", "sdfdd");
            Paitent paitent2 = new Paitent("John", "Doe", "aa@aa.com", 567890, "nothin", medicalHistory2, insuranceDetail2
                );
            Doctor doctor2 = new Doctor("Doctor", "dsfdsfds", "343@dfds.com", 324455);
            Appointment appointment2 = new Appointment(paitent2, "08:10", doctor2, "23/10/1992", "dsfsdfdsfsd");

            AppointmentList appList = new AppointmentList();
            appList.Add(appointment);
            appList.Add(appointment1);
            appList.Add(appointment2);
            return appList;
            
        }

        public List<Doctor> docList()
        {
            List<Doctor> li = new List<Doctor>();
            Doctor doctor1 = new Doctor("Stephen", "Smith", "ss@dfds.com", 324455);
            Doctor doctor2 = new Doctor("Jeffrey", "Williams", "jw@dfds.com", 123456);
            Doctor doctor3 = new Doctor("Charles", "Brown", "cb@dfds.com", 789456);
            Doctor doctor4 = new Doctor("Daniel", "Jones", "dj@dfds.com", 456123);
            Doctor doctor5 = new Doctor("Steven", "Davis", "sd@dfds.com", 123789);
            li.Add(doctor1);
            li.Add(doctor2);
            li.Add(doctor3);
            li.Add(doctor4);
            li.Add(doctor5);
            return li;
        }
    }
}
