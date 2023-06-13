using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContentType { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }
        public List<Content> Content { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
}