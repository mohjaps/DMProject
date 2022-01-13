using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMProject.Models.View_Models
{
    internal class RoundView
    {
        public string Name { get; set; }
        public int totalQuestions { get; set; }
        public string RoundScore { get; set; }
        public string TotalTimeConsumed { get; set; }
        public DateTime RoundDateTime { get; set; }

    }
}
