using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<BenimTip>
    {
        BenimTip[] elemanlar;
        public MyList()
        {
            elemanlar = new BenimTip[0];
        }
        public void Add(BenimTip eleman)
        {
            BenimTip[] geciciDizi = elemanlar;
            elemanlar = new BenimTip[elemanlar.Length + 1];
            for (int i = 0; i < geciciDizi.Length; i++)
            {
                elemanlar[i] = geciciDizi[i];
            }

            elemanlar[elemanlar.Length - 1] = eleman;

            Console.WriteLine("Add Bitti");
        }
        public int Length
        {
            get { return elemanlar.Length; }
        }

        public BenimTip[] Elemanlar
        {
            get { return elemanlar; }
        }

    }
}
