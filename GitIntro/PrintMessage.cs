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
            Andreas andreas = new Andreas();
            Karin karin = new Karin();
            Hanieh hanieh = new Hanieh();
            

            List<People> peopleList = new List<People>{andreas, karin, hanieh };

            for (int i = 0; i < peopleList.Count; i++)
            {
            Console.WriteLine($"Hello from {peopleList[i].name}");
            }
         


        }


    }
}
