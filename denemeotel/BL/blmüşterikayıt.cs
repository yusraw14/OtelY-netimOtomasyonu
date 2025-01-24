using denemeotel.DAL;
using denemeotel.ENTİTYLAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeotel.BL
{
    internal class blmüşterikayıt
    {
        internal bool MüşteriKaydet(string Adı, string Soyadı, string TelefonNo, string TCKimlikNo, string OdaNo, string Ücret, string GirişTarihi, string ÇıkışTarihi)
        {
            return (new dalmüşterikayıt()).MüşteriKaydet(new elmüşterikayıt(Adı, Soyadı, TelefonNo, TCKimlikNo, OdaNo, Ücret, GirişTarihi, ÇıkışTarihi));
        }

        internal bool OdaDurumunuGüncelle(string odaNo, string durum)
        {
            return (new dalmüşterikayıt()).OdaDurumunuGüncelle(odaNo, durum);
        }
    }
}
