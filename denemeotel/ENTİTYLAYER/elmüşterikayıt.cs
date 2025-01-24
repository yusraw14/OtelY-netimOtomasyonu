using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeotel.ENTİTYLAYER
{
    internal class elmüşterikayıt
    {
        private string Adı;
        private string Soyadı;
        private string TelefonNo;
        private string TCKimlikNo;
        private string OdaNo;
        private string Ücret;
        private string GirişTarihi;
        private string ÇıkışTarihi;


        public string ADI { get { return Adı; } set { Adı = value; } }
        public string SOYADI { get { return Soyadı; } set { Soyadı = value; } }
        public string TELEFONNO { get { return TelefonNo; } set { TelefonNo = value; } }
        public string TCKİMLİKNO { get { return TCKimlikNo; } set { TCKimlikNo = value; } }
        public string ODANO { get { return OdaNo; } set { OdaNo = value; } }
        public string ÜCRET { get { return Ücret; } set { Ücret = value; } }
        public string GİRİŞTARİHİ { get { return GirişTarihi; } set { GirişTarihi = value; } }
        public string ÇIKIŞTARİHİ { get { return ÇıkışTarihi; } set { ÇıkışTarihi = value; } }

        public elmüşterikayıt(string Adı, string Soyadı, string TelefonNo, string TCKimlikNo, string OdaNo, string Ücret, string GirişTarihi, string ÇıkışTarihi)
        {
            this.ADI = Adı;
            this.SOYADI = Soyadı;
            this.TELEFONNO = TelefonNo;
            this.TCKİMLİKNO = TCKimlikNo;
            this.ODANO = OdaNo;
            this.ÜCRET = Ücret;
            this.GİRİŞTARİHİ = GirişTarihi;
            this.ÇIKIŞTARİHİ = ÇıkışTarihi;
        }
    
        public override string ToString()
        {
            return this.ADI + "-" + this.SOYADI + "-" + this.TELEFONNO + "-" + this.TCKİMLİKNO + "-" + this.ODANO + "-" + this.ÜCRET + "-" + this.GİRİŞTARİHİ + "-" + this.ÇIKIŞTARİHİ + "-" ;

        }
    }
}
