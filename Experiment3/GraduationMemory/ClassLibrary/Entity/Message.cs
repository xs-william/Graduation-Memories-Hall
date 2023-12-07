using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Message
    {
        [Key]
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
        public bool Permit { get; set; }

        // 外键
        public string BoxId { get; set; }

        public Message() { }

        public Message(string content, DateTime date, string owner, bool permit, string boxId)
        {
            Id = Guid.NewGuid().ToString();
            Content = content;
            Date = date;
            Owner = owner;
            Permit = permit;
            BoxId = boxId;
        }
    }
}
