using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr6
{
    public class VotingSystem
    {

        private VoteOption[] votes;
        private int yesVotes;
        private int noVotes;


        public VotingSystem(int size)
        {
            votes = new VoteOption[size];
            yesVotes = 0;
            noVotes = 0;
        }


        public void CastVote(VoteOption vote)
        {
            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] == 0)
                {
                    votes[i] = vote;


                    if (vote == VoteOption.Yes)
                    {
                        yesVotes++;
                    }
                    else if (vote == VoteOption.No)
                    {
                        noVotes++;
                    }
                    break;
                }
            }
        }


        public void DisplayResults()
        {
            Console.WriteLine("\nVoting Results:");
            Console.WriteLine($"Yes Votes: {yesVotes}");
            Console.WriteLine($"No Votes: {noVotes}");
        }
    }
}
