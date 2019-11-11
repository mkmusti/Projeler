using MustiYazilim.OgrenciTakip.Model.Entities;
using MustiYazilim.OgrenciTakip.Model.Entities.Base;

namespace MustiYazilim.OgrenciTakip.Model.Dto
{
    public class OkulS : Okul
    {
        //Attribute
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }

    public class OkulL : BaseEntity
    {
        public string OkulAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }

    }
}