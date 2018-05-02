using System;
using System.IO;

namespace Pract12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader fileIn = new StreamReader("input.txt");
            StreamWriter fileOut = new StreamWriter("output.txt");
            string inputData = fileIn.ReadLine();
            int n = int.Parse(fileIn.ReadLine());
            Client[] person = new Client[n];
            for (int i = 0; i < n; i++)
            {
                string[] text = fileIn.ReadLine().Split(' ');
                if (text.Length == 4)
                {
                    person[i] = new Investor(text[0], text[1], int.Parse(text[2]), int.Parse(text[3]));
                }
                else
                {
                    if (text.Length == 5)
                    {
                        person[i] = new Creditor(text[0], text[1], int.Parse(text[2]), int.Parse(text[3]), int.Parse(text[4]));
                    }

                    else
                    {
                        if (text.Length == 6)
                        {
                            person[i] = new Organization(text[0], text[1], int.Parse(text[2]), int.Parse(text[3]), int.Parse(text[4]), int.Parse(text[5]));
                        }

                    }
                }
            }

            fileOut.WriteLine("Все клиенты банка:");
            foreach (Client p in person)
                p.Info(fileOut);
            
            fileOut.WriteLine("Клиенты, начавшие сотрудничество с банком с {0} :", inputData);
            foreach (Client p in person)
                if (p.partnershipData(inputData)) fileOut.WriteLine(p.ClientName);

            fileOut.WriteLine();

            fileOut.WriteLine("Сортировка по дате открытия счета:");
            Array.Sort(person);
            foreach (Client p in person)
            {
                fileOut.WriteLine(p.ClientName);
            }

            fileIn.Close();
            fileOut.Close();
        }
    }
}
