using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyComments
{
   public   class ReplyComments
    {
        public int ReplyCom_ID { get; set; }
        public int Commets_ID{ get; set; }
        public int User_ID{ get; set; }
        public string ReplyComContent{ get; set; }
        public DateTime ReplyCom_Time{ get; set; }
    }
}
