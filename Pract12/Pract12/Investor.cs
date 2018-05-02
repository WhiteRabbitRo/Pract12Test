using System;

namespace Pract12
{
   public class Investor : Client
    {
        public Investor(string Name, string Data, int Amount, int Percent) : base(Name, Data, 0, Amount, Percent,  0)
        { }

        public override void Info(System.IO.StreamWriter fileOut)
        {
            fileOut.WriteLine("Фамилия Вкладчика: " + Name + 
                              "\nДата открытия вклада: " + Date.ToShortDateString() + 
                              "\nРазмер вклада: "+ Amount +
                              "\nПроцент по вкладу: " + Percent + "\n");
        }

        public override bool partnershipData(string inputData)
        {
            if (Date == DateTime.Parse(inputData))
            {
                return true;
            }
            return false;
        }
    }
}
