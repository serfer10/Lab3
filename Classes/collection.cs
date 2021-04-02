using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Collection
    {
        List<Student> array = new List<Student>();
        public void Add(Student student)
        {
            array.Add(student);
        }
        public Student this[string LastName]
        {
            get
            {
                return array.Find(student => { return student.LastName == LastName; });
            }
        }
    }
}
