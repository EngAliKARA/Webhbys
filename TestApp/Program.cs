using Hbys.Core;
using Hbys.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    class Program
    {
        //    GenericUnitOfWork unitOfWork = new GenericUnitOfWork();
        static void Main(string[] args)
        {


            try
            {
                

                ////var item = items.SingleOrDefault();
                ////Console.WriteLine("{0} {1} {2} {3} {4} ", item.PER_ID, item.ADI, item.SOYADI, item.EHNO, item.BT);
                //using (PersonelUnitOfWork PerEntity = new PersonelUnitOfWork())
                //{
                //    //PER_KIMLIK Personel = new PER_KIMLIK();
                //    //Personel.PER_ID = 1052;
                //    //Personel.TCKIMLIK_NO = "47626487914";
                //    //Personel.ADI = "Ali";
                //    //Personel.SOYADI = "KARA HAYIRLI CUMALAR";
                //    //PerEntity.PerKimlikRepo.Insert(Personel);
                //    //PerEntity.Save();

                //    int PERID = 599;
                //    //PerEntity.PerKimlikRepo.Update(Personel);
                //    //var books = PerEntity.PerKimlikRepo.Select();
                //    //// Console.WriteLine("{0} {1} {2}", book.TCKIMLIK_NO, book.ADI,book.SOYADI);
                //    //foreach (var book in books)
                //    //{
                //    //    Console.WriteLine("{0} {1} {2}", book.TCKIMLIK_NO, book.ADI, book.SOYADI);
                //    //}
                //    //Console.WriteLine("DENEME");
                //    //Console.ReadKey();
                //    //kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkvar PERID = 599;
                //    var items = from P in PerEntity.PerKimlikRepo.Select()
                //                join UP in PerEntity.PerEhliyetRepo.Select() on P.PER_ID equals UP.PER_ID
                //                where P.PER_ID == PERID
                //                select new
                //                {
                //                    PER_ID = P.PER_ID,
                //                    ADI = P.ADI,
                //                    SOYADI = P.SOYADI,
                //                    EHNO = UP.BELGE_NO,
                //                    BT = UP.BELGE_TRH
                //                };

                //    var item = items.SingleOrDefault();
                //    Console.WriteLine("{0} {1} {2} {3} {4} ", item.PER_ID, item.ADI, item.SOYADI, item.EHNO, item.BT);
                //    /* foreach (var item in items)
                //     {
                //         Console.WriteLine("{0} {1} {2} {3} {4} ", item.PER_ID,item.ADI, item.SOYADI, item.EHNO, item.BT);
                //     }*/

                    Console.ReadKey();
                //}
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadKey();
            }
        }
    }
    public IEnumerable<object> Deneme1()
    {
        GenericUnitOfWork unitOfWork = new GenericUnitOfWork();
        PER_KIMLIK Personel = new PER_KIMLIK
        {
            PER_ID = 1052,
            TCKIMLIK_NO = "47626487914",
            ADI = "Ali",
            SOYADI = "KARA HAYIRLI CUMALAR",
        };
        var SONUC = unitOfWork.Repository<PER_KIMLIK>().Insert(Personel);
        unitOfWork.Save();
        var PERID = 599;

        var items = from P in unitOfWork.Repository<PER_KIMLIK>().Select(null)
                    join UP in unitOfWork.Repository<PER_EHLIYET>().Select(null) on P.PER_ID equals UP.PER_ID
                    where P.PER_ID == PERID
                    select  new object
                    {
                        PER_ID = P.PER_ID,
                        ADI = P.ADI,
                        SOYADI = P.SOYADI,
                        EHNO = UP.BELGE_NO,
                        BT = UP.BELGE_TRH
                    };
        return items;
    }
    public class deneme
    {
        public int PER_ID { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string EHNO { get; set; }
        public DateTime? BT { get; set; }
    }
}
