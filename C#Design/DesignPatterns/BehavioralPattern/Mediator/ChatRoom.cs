using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Mediator
{
    // Concrete Mediator
    public class ChatRoom : IChatRoom
    {
        private List<User> users = new List<User>();

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage($"Message from {sender.Username}: {message}");
                }
            }
        }
    }
}


/*
Mediator  (IChatroom)
    defines an interface for communicating with Colleague objects
ConcreteMediator  (Chatroom)
    implements cooperative behavior by coordinating Colleague objects
    knows and maintains its colleagues
Colleague classes  (Participant)
    each Colleague class knows its Mediator object
    each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague
 */