using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_OccurencesOfEachChar
{
    class Program
    {
        static void Main(string[] args)
        {
            OccurencesOfChar ch = new OccurencesOfChar();
            ch.Occurence();

            ReverseString rev = new ReverseString();
            rev.Reverse();

            RevOrderOfWords revs = new RevOrderOfWords();
            revs.RevOrder();

            RevEachWord reveach = new RevEachWord();
            reveach.RevEach();

            PossibleSubStr poss = new PossibleSubStr();
            poss.Possible();

            SecLargestInt sec = new SecLargestInt();
            sec.Largest();

            Console.ReadKey();
        }
    }
}
