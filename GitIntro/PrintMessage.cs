using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace GitIntro
{
    public class PrintMessage
    {

        public void showHello()
        {
            People andreas = new Andreas();
            People karin = new Karin();
            People hanieh = new Hanieh();

            List<People> peopleList = new List<People>{andreas, karin, hanieh };

            foreach (var person in peopleList)
            {

            Console.WriteLine($"Hello from {person.name}");
            }
         


        }


    }
}
