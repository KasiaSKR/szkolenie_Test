using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Kroki projektu "ProjektEF_Dzien3"
        1. Dodanie nowego projektu typu Class Library: "EF.Model" - wszystko będzie na nim bazowało
        2. Dodanie nowego projektu typu Class Library: "EF.DAL" - klasa kontekstowa
        2. Dodanie nowego projektu tyou Class Library: "EF.Repository" 
        4. Dodanie Consoli "EF.ClientConsole"
        5. Usunięcie automatycznie dodanych klas "Class1" w EF.DAL, EF.Model. EF.Repository
        6. Dodaj referejce do EF DAL -> EF.Model
        7. W EF.Repository -> dodanie referencji EF.Dal i EF.Model
        8. W EF.ClientConsole -> dodanie referejcni EF.DAL i EF.Repository
        9. Dodanie do EF.Model klasy "Person"
        10. Klasa "Person" - publiczna; dodanie Id, Name, Age
        11. EF.Model - dodanie EntityFramework
        12. Dodanie wymagań co do wpisywanych znaków - [Required]
        13. Dodanie EntityFramework do EF.DAL
        14. Dodanie klasy "MyContext" do EF.DAL
        15. Dodanie using System.Data.Entity do class Mycontext :DbContext
        16. Utworzenie interfejsu "IGenericRepo" w EF.Repository
        17. Dodanie interfejsu "IRepoPerson" - dodanie AddPerson, Delete...
        18. 

        19. W EF.ClientConsole utworzenie bazy danych i potem consolestrings.
*/



namespace EF.ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Generycznosc<int> generycznoscInt = new Generycznosc<int>();

            generycznoscInt.GetData(123);


        }


    }



    // Dodatkowy temat
    //Generyczność  --uniwersalna klasa
    
    class Generycznosc<Cokolwiek> //uniwersalna klasa generyczna, której wskazujemy tylko jakiej klasy jest
    {
        public Cokolwiek GetData(Cokolwiek i)
        {
            return i;
        }

        //ZAMIAST:
        ////public int GetData(int i) //przyjmowanie int i zwracanie int
        ////{
        ////    return i;
        ////}

        ////public string GetData(string i)
        ////{
        ////    return i;
        ////}

    }


}
