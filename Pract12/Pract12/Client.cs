using System;

namespace Pract12
{
    public abstract class Client: IComparable<Client>
    {
        public string Name;//Фамилия вкладчика, кредитора или название организации 
        public DateTime Date;//Дата открытия вклада, выдачи кредита или открытия счета
        public int Amount;//Размер вклада, кредита или сумма на счету
        public int Percent;//Процент по вкладу или кредиту
        public int Debt;//Остаток долга по кредиту
        public int AccountNum;//Номер счета

        public Client(string name, string date, int accout, int amount, int percent, int debt)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.AccountNum = accout;
            this.Amount = amount;
            this.Percent = percent;
            this.Debt = debt;

        }

        public abstract void Info(System.IO.StreamWriter fileOut);

        public int CompareTo(Client person)
        {
            return this.Date.CompareTo(person.Date);
        }

        public abstract bool partnershipData(string inputData);

        public string ClientName
        {
            get 
            { 
                return Name; 
            }
        }
    }
}
