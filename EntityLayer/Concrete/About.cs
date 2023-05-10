using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]//Atadığımız Property'i(AboutID) Birincil anahtar yapar.
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image1 { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public bool Status { get; set; }
    }
}
