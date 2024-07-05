using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class Student
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public string RegistrationCode { get; set; }
        public string FirstSurtname { get; set; }
        public string SecondSurtname { get; set; }
        public string FirstName { get; set; }
        public string Sex { get; set; }
        public DateTime DateBirth { get; set; }
        public string Dni { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string PlaceBirth { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public string Home { get; set; }
        public string Work { get; set; }
        public string WorkPosition { get; set; }
        public string CivilStatus { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string NumberContactEmergency { get; set; }
        public string DegreeAchieved { get; set; }
        public string FamilyBurden { get; set; }
        public int NumberPeopleCharge { get; set; }
        public string PhoneOperator { get; set; }
        public string TeamTechnology { get; set; }
        public string InternetHome { get; set; }
        public string Disability { get; set; }
        public string TypeDisability { get; set; }
        public string NativeLenguage { get; set; }
        public byte[] PhotoDni { get; set; }
        public string FileNamePdf { get; set; }
        public string Departament { get; set; }
        public string PlaceDate { get; set; }
    }
}
