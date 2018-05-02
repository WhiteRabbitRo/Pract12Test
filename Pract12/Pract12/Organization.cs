using System;

namespace Pract12
{
    public class Organization : Client
    {
        //название, дата открытия счета, номер счета, сумма на счету
        public Organization(string Name, string Data, int AccountNum, int Amount,  int Persent, int Debt) :
        base(Name, Data, AccountNum, Amount, 0, 0)
        {}

        public override void Info(System.IO.StreamWriter fileOut)
        {
            fileOut.WriteLine("Название Организации: " + Name +
                              "\nДата открытия счета: " + Date.ToShortDateString() +
                              "\nНомер счета: " + AccountNum +
                              "\nСумма на счету: " + Amount + "\n");
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
