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
        public string PlayerUsername { get; set; }
        public int totalQuestions { get; set; }
        public int solvedQuestions { get; set; }
        public string selectedTables { get; set; }
        public int timeConsumed { get; set; }
        public int correct {get; set;}
        public int wrong {get; set;}
        public int Score { get; set; }
        public DateTime RoundDateTime { get; set; }
    }
}
