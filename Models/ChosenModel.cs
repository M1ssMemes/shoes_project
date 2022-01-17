using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ChosenModel
    {
        public int ID { get; set; }
        public TestResults TestResults { get; set; }
        public BaseModel BaseModel { get; set; }
        public Size Size { get; set; }
    }
}
