using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class Message
    {
        public string BCC { get; set; }
        public string CC { get; set; }
        public int CategoryID { get; set; }
        public int FromUser { get; set; }
        public DateTime? IsReplied { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? Complete { get; set; }
        public string MessageHTML { get; set; }
        public string MessageText { get; set; }
        public string SenderMail { get; set; }
        public string Subject { get; set; }
    }
}
