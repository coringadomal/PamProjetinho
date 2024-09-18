using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho.Models
{
    public class post
    {
        private string userId;
        private string id;
        private string title;
        private string body;

        public string UserId { get => userId; set => userId = value; }
        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }
    }
}
