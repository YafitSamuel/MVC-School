using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_School_app.Models
{
    public class Pupil
    {
        public int id;
        public string firstName;
        public string lastName;
        public int age;
        public string classRoom;

        public Pupil(int id, string firstName, string lastName, int age, string classRoom)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.classRoom = classRoom;

        }
    }
}