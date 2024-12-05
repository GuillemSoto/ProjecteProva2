using System;
namespace Main
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Ex3());
        }
        public static void Ex5PtA()
        {
            const string CanviFuncio = "----------------";
            int[] Llista = new int[20];
            int Reorganitzar = 0;
            for(int i=0; i<Llista.Length; i++)
            {
                Llista[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<Llista.Length; i++)
            {
                for(int j=i+1; j<Llista.Length; j++)
                {
                    if (Llista[j] < Llista[i])
                    {
                        Reorganitzar = Llista[j];
                        Llista[j] = Llista[i];
                        Llista[i] = Reorganitzar;
                    }
                }
            }
            Console.WriteLine(CanviFuncio);
            Console.WriteLine(Ex5PtB(Llista));
        }
        public static bool Ex5PtB(int[] Llista)
        {
            bool valid = false;
            int userNum = int.Parse(Console.ReadLine());
            for(int i = 0; i < Llista.Length; i++)
            {
                if (userNum == Llista[i])
                {
                    valid = true;
                }
            }
            return valid;
        }
        public static bool Ex3()
        {
            const string introText = "Introdueix el dia, mes i any";
            const int minDayMonth = 1;
            const int maxDayMonth = 31;
            Console.WriteLine(introText);
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            
            if (day > totalDaysMonth(day, month, year, minDayMonth, maxDayMonth) || totalDaysMonth(day, month, year, minDayMonth, maxDayMonth)==0)
            {
                return false;
            }
            else { return true; }
        }
        public static int totalDaysMonth(int day, int month, int year, int minDayMonth, int maxDayMonth)
        {
            if (day < minDayMonth || day > maxDayMonth) { return 0; }
            switch (month)
            {
                case 1: return 31;
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
            }
            if (month == 2)
            {
                if(year%4 == 0){
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else return 0;
        }
    }
}
