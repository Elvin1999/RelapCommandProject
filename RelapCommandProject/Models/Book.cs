using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelapCommandProject.Models
{
   public class Book:Entity
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}
