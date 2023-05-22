using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.Models
{
    public class Content
    {
        public int ContentId { get; set; }
        public int SubjectId { get; set; }
        public string ContentType { get; set; }
        public string ContentTitle { get; set; }
        public byte[] ContentData { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
