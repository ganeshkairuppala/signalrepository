using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication32
{
    public class MyHub:Hub
    {
        public void Anounce(string msg)
        {
            Clients.All.Anounce(msg);

        }
    }
}