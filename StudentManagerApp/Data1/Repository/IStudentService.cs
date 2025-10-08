﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentManagerApp.Data1.Repository
{
    public interface  IStudentService
    {
        List<Student> GetStudents();
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(string student);
        void SortByName();
        void SortByGrade();

    }
}
