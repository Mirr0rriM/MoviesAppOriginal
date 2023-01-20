using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.ViewModels
{

    public class InputActorViewModel
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [DataType(DataType.Date)] 
        public DateTime BirthDate { get; set; }
    }
}