using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Repository.Entity
{
    [Table("Template", Schema = "iNet")]
    public class Template
    {
        public int TemplateId { get; set; }
        public string Name { get; set; }

        public ICollection<Colume> Columes { get; set; }
    }
}