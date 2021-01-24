using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace EnumKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Kimi zaman kodların daha kolay yazılmasını ve okunmasını sağlarken çoğunlukla hata yapılmasını engellemek için kullanılır.

            //.Net Framework üzerinde hazır enumlar olduğu gibi kullanıcı tanımlı enumlar da hazırlanabilir.


            #endregion

            #region Kullanım
            //Console.WriteLine("Bugün = " + HaftaninGunleri.cumartesi);
            //Console.WriteLine("Haftanın = " + (int)HaftaninGunleri.cumartesi + ". günü");
            //Console.WriteLine((HaftaninGunleri)6);
            #endregion

            #region Kullanım 2

            DataModel db = new DataModel();
            //Console.WriteLine(db.KategoriSil(3));
            ModelSonuc ms = db.KategoriSil(24);

            switch (ms)
            {
                case ModelSonuc.Basarili:
                    Console.WriteLine("Kategori silme işlemi başarılı");
                    break;
                case ModelSonuc.Basarisiz:
                    Console.WriteLine("Kategori silme işlemi başarısız");
                    break;
                case ModelSonuc.Kullanimda:
                    Console.WriteLine("Silinmek istenen kategori kullanımda");
                    break;
                default:
                    break;
            }
            #endregion
        }
    }
    public enum HaftaninGunleri
    {
        pazartesi = 1,
        sali,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar
    }
}
