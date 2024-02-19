using Main.Business.Abstract;
using Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Business.Concretes
{
    public class InstructorManager:IManager<Instructor>
    {
        List<Instructor> instructors;
        public InstructorManager() 
        {
            Instructor instructor1 = new Instructor();
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demirog";
            instructor1.Id = 1;

            Instructor instructor2 = new Instructor();
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalayci";
            instructor2.Id = 2;

            instructors = new List<Instructor> { instructor1, instructor2};
        }
        public List<Instructor> GetAll()
        {
            return instructors;
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }
        public void Remove(Instructor instructor)
        {
            instructors.Remove(instructor);
        }
    }
}
