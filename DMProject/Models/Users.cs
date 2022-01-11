using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMProject.Models
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StaetDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int Score { get; set; }
        public int TotalScore { get; set; }

    }
}
