using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.Models
{
    public class Content : IEnumerable
    {
        public int ContentId { get; set; }
        public int SubjectId { get; set; }
        public string ContentType { get; set; }
        public string ContentTitle { get; set; }
        public byte[] ContentData { get; set; }
        public DateTime DateAdded { get; set; }


        public List<Content> ContentList { get; set; }

        public IEnumerator GetEnumerator()
        {
            return ContentList.GetEnumerator();
        }

        public string ContentPath
        {
            get
            {
                string extension = Path.GetExtension(ContentTitle);
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EssaiGallery", ContentType, ContentTitle + extension);
            }
        }
    }
}