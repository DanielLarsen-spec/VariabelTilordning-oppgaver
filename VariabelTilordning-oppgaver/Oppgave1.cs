using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariabelTilordning_oppgaver
{
    internal class Oppgave1
    {
        public void Run()
        {
            var input1 = Convert.ToInt32(Console.ReadLine());
            var input2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine(AddNumb(input1, input2));

        }
        private int AddNumb(int numb1, int numb2)
        {
            return numb1 + numb2;

        }

    }
}
