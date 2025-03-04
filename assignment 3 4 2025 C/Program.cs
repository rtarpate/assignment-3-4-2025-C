using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_4_2025_C
{
    internal class Program
    {
        static Dictionary<string, int> votes = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            string can1 = "Trump";

            string can2 = "Kamala";

            string can3 = "Kenny";

            int choice = 0;

           

            votes.Add(can1, 0);
            votes.Add(can2, 0);
            votes.Add(can3, 0);

            while (true)
            {
                Console.WriteLine($" who do you vote for 1 for {can1} 2 for {can2} 3 for {can3} 4 for reset votes");

                choice =Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CastVoted(can1);
                        break;
                    case 2:
                        CastVoted(can2);
                        break;
                    case 3:
                        CastVoted(can3);
                        break;
                    case 4:
                        ResetVotes();
                        break;
                    default:
                        break;
                }
            }

        }

        static void CastVoted(string candidateName)
        {
            votes[candidateName]++;

            DisplayResults();

            Console.WriteLine();

        }

        static void DisplayResults()
        {
            foreach (KeyValuePair<string, int> vote in votes)
            {
                Console.WriteLine(vote.Key + " " + vote.Value);
            }
            Console.WriteLine();

        }

        static void ResetVotes()
        {
            //creates a new votes dictionary have the count 0 for all candidates
            Dictionary<string, int> newvotes = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> vote in votes)
            {
                newvotes.Add(vote.Key, 0);
            }

            votes = newvotes;

            DisplayResults();

            Console.WriteLine();


        }
    }
}
