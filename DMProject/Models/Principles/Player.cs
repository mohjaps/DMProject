using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMProject.Models.Principles
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
