using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Model
{
    //tworzenie atrybutu
    [Table("tblPerson")] //dodanie using System.ComponentModel.DataAnnotations.Schema;

    public class Person
    {
        [Key] //oznacza, że jest to klucz podstawowy
        public int Id { get; set; } //id jest autoinkrementowane

        //dodanie using System.ComponentModel.DataAnnotations;
        [Required] //required - jest wymagane
        [MaxLength(20)] //ograniczenie długości znaków
        public string Name { get; set; } //nazwa jest wymagana

        
        [Range(1,99)] //zakres dla wieku
        public int Age { get; set; }
    }
}
