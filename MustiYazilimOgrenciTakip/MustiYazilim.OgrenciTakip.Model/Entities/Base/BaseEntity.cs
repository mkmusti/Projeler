using MustiYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;

namespace MustiYazilim.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        public long Id { get; set; }
        public string Kod { get; set; }
    }
}