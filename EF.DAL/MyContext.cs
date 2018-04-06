using EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DAL
{
    public class MyContext : DbContext
    {
        //tworzenie konstruktora
        public MyContext():base("MyDB")  //base - wróć do klasy bazowej, do której dziedziczymy
        {

        }

        public DbSet<Person> Persons { get; set; } //using EF.Model






        //wyłączenie nadpisywania nazw
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //base.-wywołaj mi logikę z klasy bazowej

            modelBuilder.Conventions.Remove(new System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention());  //pozbywanie się końcówek - sufixów
            
        }

    }
}
