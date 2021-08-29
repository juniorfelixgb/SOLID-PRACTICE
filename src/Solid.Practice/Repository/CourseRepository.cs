using System;
using System.Collections.Generic;
using System.Linq;
using Solid.Practice.Models;
using Solid.Practice.Utilities;

namespace Solid.Practice.Repository
{
    public class CourseRepository : Utils
    {
        private readonly List<Course> _courses;

        public CourseRepository()
        {
            _courses = new List<Course>();
        }
        public List<Course> GetCourses()
        {
            return _courses;
        }
        public void AddEntry(Course entry) => _courses.Add(entry);

        public void RemoveEntryAt(int index) => _courses.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, _courses.Select(x => $"Curso: {x.Name}, Estudiantes: {x.Students}, Valoración: {x.Rating}, Inicio: {FormatDate(x.StartDate)}, Pago: {ShowMoney(x.Pay)}"));
    }
}