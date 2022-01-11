using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMProject.Models.Principles
{
    internal class Round
    {
        public int Id { get; set; }
        public int PlayerUsername { get; set; }
        public int Score { get; set; }
        public int RoundDateTime { get; set; }
    }
}
