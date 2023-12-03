using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Mediator
{
    // Mediator interface
    public interface IChatRoom
    {
        void RegisterUser(User user);
        void SendMessage(string message, User sender);
    }
}
