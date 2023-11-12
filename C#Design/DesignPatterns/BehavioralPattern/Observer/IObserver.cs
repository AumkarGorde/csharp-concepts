using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern
{
    // Observer Interface
    public interface IObserver
    {
        void Update(string itemName, decimal currentBid, string winningBidder);
    }

}
