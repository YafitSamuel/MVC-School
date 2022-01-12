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
        public static List<Pupil> Pupils = new List<Pupil>()
        {
         new Pupil(0,"yafit", "samuuel", 12, "aa"),
         new Pupil(1,"romi", "samuuel", 13, "bb"),
         new Pupil(2,"lior", "dana", 14, "cc"),
         new Pupil(3,"tal", "ron", 15, "dd")
       };
    }
}