using BehavioralPattern;
using BehavioralPattern.Mediator;

Console.WriteLine("Observer Pattern");

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

Console.WriteLine("Mediator Pattern");

// Create chat room (mediator)
var chatRoom = new ChatRoom();

// Create users (colleagues) and register them with the chat room
var user1 = new ChatUser("Alice", chatRoom);
var user2 = new ChatUser("Bob", chatRoom);
var user3 = new ChatUser("Charlie", chatRoom);

chatRoom.RegisterUser(user1);
chatRoom.RegisterUser(user2);
chatRoom.RegisterUser(user3);

// Users communicate through the chat room
user1.SendMessage("Hello, everyone!");
user2.SendMessage("Hi, Alice!");
user3.SendMessage("Hey, what's up?");