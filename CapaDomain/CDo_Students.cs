using CapaData;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_Students
    {
        CD_Students objStudent = new CD_Students();
        public void AddStudent(Student student)
        {
           objStudent.AddStudent(student);
        }
       
        public void UpdateStudent(Student student)
        {
           objStudent.UpdateStudent(student);
        }
        public void DeleteStudent(int studentId)
        {
            objStudent.DeleteStudent(studentId);
        }
        public DataTable SearchStudent(string buscar)
        {
            return objStudent.SearchStudent(buscar);
        }
        public List<Student> LoadStudents()
        {
            return objStudent.LoadStudents();
        }
       
    }
}
