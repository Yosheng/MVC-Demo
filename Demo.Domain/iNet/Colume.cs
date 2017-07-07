using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Domain
{
    [Table("Colume", Schema = "iNet")]
    public class Colume
    {
        public int ColumeId { get; set; }
        public bool Vaild { get; set; }
        public bool Show { get; set; }
        public string Name { get; set; }
        public string JsonTag { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }
        public int Limit { get; set; }

        public Template Template { get; set; }
    }
}