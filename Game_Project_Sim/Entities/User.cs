using Game_Project_Sim.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Sim.Entities
{
   public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
