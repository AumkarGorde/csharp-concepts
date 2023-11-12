using BehavioralPattern;

Console.WriteLine("Behavioral Pattern");

AuctionItem paintingAuction = new AuctionItem("Ronaldo Champion's League Shoes", 1000m);

// Creating bidders
IObserver bidder1 = new Bidder("Mark Twain");
IObserver bidder2 = new Bidder("Santiago Gonzales");
IObserver bidder3 = new Bidder("Dilbar Godse");

// Adding bidders to the auction item
paintingAuction.AddObserver(bidder1);
paintingAuction.AddObserver(bidder2);
paintingAuction.AddObserver(bidder3);


// Bidders place bids
paintingAuction.PlaceBid(1200m, "Mark Twain");
paintingAuction.PlaceBid(1500m, "Santiago Gonzales");
paintingAuction.PlaceBid(1300m, "Dilbar Godse");

Console.ReadKey();