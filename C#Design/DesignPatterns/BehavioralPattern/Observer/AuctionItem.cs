using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    public class AuctionItem : ISubject
    {
        private string itemName;
        private decimal currentBid;
        private List<IObserver> bidders = new List<IObserver>();

        public string ItemName => itemName;
        public decimal CurrentBid => currentBid;

        public AuctionItem(string itemName, decimal initialBid)
        {
            this.itemName = itemName;
            this.currentBid = initialBid;
        }

        public void PlaceBid(decimal bidAmount, string bidderName)
        {
            if (bidAmount > currentBid)
            {
                currentBid = bidAmount;
                NotifyObservers(bidderName);
            }
            // Additional logic for handling invalid bids, etc.
        }

        public void AddObserver(IObserver observer)
        {
            bidders.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            bidders.Remove(observer);
        }

        public void NotifyObservers(string bidderName)
        {
            foreach (var bidder in bidders)
            {
                bidder.Update(itemName, currentBid, bidderName);
            }
        }
    }

}
