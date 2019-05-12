using System;
using System.Collections.Generic;
using System.Text;

namespace RiseModels
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Id { get; set; }
        public bool IsStreamer { get; set; } = false;
        public bool IsOnline { get; set; } = false;

    }
}
