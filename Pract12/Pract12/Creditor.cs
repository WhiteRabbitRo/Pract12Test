using System;

namespace Pract12
{
    public class Creditor : Client
    {
        //фамилия, дата выдачи кредита, размер кредита, процент по кредиту, остаток долга
        public Creditor(string Name, string Data, int Amount, int Percent, int Debt) : 
                        base(Name, Data, 0, Amount, Percent, Debt)
        { }

        public override void Info(System.IO.StreamWriter fileOut)
        {
            fileOut.WriteLine("Фамилия Кредитора: " + Name +
                              "\nДата выдачи кредита: " + Date.ToShortDateString() +
                              "\nРазмер кредита: " + Amount +
                              "\nПроцент по вкладу: " + Percent + 
                              "\nОстаток долга: " + Debt + "\n");
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
