using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    // Concrete Observer
    public class Bidder : IObserver
    {
        private string bidderName;

        public Bidder(string bidderName)
        {
            this.bidderName = bidderName;
        }

        public void Update(string itemName, decimal currentBid, string winningBidder)
        {
            if (bidderName == winningBidder)
            {
                Console.WriteLine($"{bidderName}: Congratulations! You are winning the auction for '{itemName}' with a bid of ${currentBid}");
            }
            else
            {
                Console.WriteLine($"{bidderName}: The current bid for '{itemName}' is ${currentBid}. Someone else is winning.");
            }
        }
    }
}
