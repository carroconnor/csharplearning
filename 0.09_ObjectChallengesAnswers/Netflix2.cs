using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ObjectChallengesAnswers
{
    class Netflix2
    {
        //Properties that our netflis object will have

        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }


        //Methods
        public void GetSuggestion()
        {
            if (this.Rating > 3.5)
            {
                Console.WriteLine("This is a good show");

            }
            else
            {
                Console.WriteLine("This show is not suggested");
            }


        }

        
    }
}
