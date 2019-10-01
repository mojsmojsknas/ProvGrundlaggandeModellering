using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvGrundlaggandeModellering
{
    class Book
    {
        //Alla egenskaper/variabler som gavs
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();

        //Behöver 2 st listor, en med kategorier och en med titlar
        //alla metoder bör vara public
        //slumpar värden för actualValue, rarity, cursed
        //namn och en kategori från olika listor.

            // då Book är en konstruktor kommer den köras på en gång och skrivs inte likadant som de övriga metoderna
        public Book()
        {
            List<string> nameList = new List<string>() {"Liftarensguide till galaxen", "Det", "Jurkjyrkogården", "Sju sorters kakor", "Hobbit" };
            List<string> categoryList = new List<string>() {"skräck", "sifi", "fantasy", "kokbok"};

            actualValue = generator.Next(100);
            rarity = generator.Next(4);

            //väljer plats i listorna 
            int nameNr = generator.Next(4);
            name = nameList[nameNr];            
            int categoryNr = generator.Next(3);
            category = categoryList[categoryNr];

            

            //fixa IsCursed


        }
        //borde göra så att man får namnet när man anropar metoden
        public string GetName()
        {
            return name;
        }

        public string GetCategory()
        {
            return category;
        }


        // multiplicerar ActualValue med rarity
        //mellan 50% och 150% av rätt värde
        public int Evaluate()
        {
           int value = actualValue * rarity;

             
            

        }

    }
}
