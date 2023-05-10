using System;

namespace SignalRApi.DAL
{
    public enum ECity
    {
        Adana = 1,
        Adıyaman = 2,
        Afyon = 3,
        Ağrı = 4,
        Amasya = 5,
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public int CityVisitCount { get; set; }
        public ECity City { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
