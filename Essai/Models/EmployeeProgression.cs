using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.Models
{
    public class EmployeeProgression
    {
        [Key, Column(Order = 0)]
        public int EmployeeId { get; set; }

        [Key, Column(Order = 1)]
        public int SubjectId { get; set; }

        public string ViewedContents { get; set; }

        [NotMapped]
        public List<int> ContentIds
        {
            get { return ViewedContents?.Split(',').Select(int.Parse).ToList() ?? new List<int>(); }
            set { ViewedContents = string.Join(",", value); }
        }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
    }
}
