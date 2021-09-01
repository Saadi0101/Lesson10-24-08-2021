using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите валюту usd, euro, rub, som: ");
            string v1 = Console.ReadLine();
            string v2 = "";
            if (v1 == "som")
            {
                Console.WriteLine("Введиту вторую валюту usd, euro, rub: ");
                v2 = Console.ReadLine();

                Console.WriteLine("Введите сумму конвертации: ");
                double s = Convert.ToDouble(Console.ReadLine());
                Converter converter = new Converter() { m1 = v1, sum = s, m2 = v2 };
                converter.GetConvert();
            }
            else if (v1 == "usd" || v1 == "euro" || v1 == "rub" )
            {
                Console.WriteLine("Вторая волюта som! ");
                Console.WriteLine("Введите сумму конвертации: ");
                double s = Convert.ToDouble(Console.ReadLine());
                Converter converter = new Converter() { m1 = v1, sum = s, m2 = v2 };
                converter.GetConvert();
            }
            else Console.WriteLine("Введена не правильная валюта!");
        }
    }


    class Converter
    {
        public string m1;
        public string m2;
        public double result;
        public double sum;
        public Converter() { }

        public void GetConvert()
        {
            if(m1 == "usd")
            {
                result = sum * 11.44;
                Console.WriteLine($"{sum} дол. = {Math.Round(result, 2)} сом.");
            }
            else if (m1 == "euro")
            {
                result = sum * 13.45;
                Console.WriteLine($"{sum} эвро = {Math.Round(result, 2)} сом.");
            }
            else if (m1 == "rub")
            {
                result = sum * 0.1535;
                Console.WriteLine($"{sum} рубл. = {Math.Round(result, 2)} сом.");
            }
            else if (m1 == "som" && m2 == "rub")
            {
                result = sum / 0.1535;
                Console.WriteLine($"{sum} сом. = {Math.Round(result, 2)} рубл.");
            }
            else if (m1 == "som" && m2 == "usd")
            {
                result = sum / 11.44;
                Console.WriteLine($"{sum} сом. = {Math.Round(result, 2)} дол.");
            }
            else if (m1 == "som" && m2 == "euro")
            {
                result = sum / 13.45;
                Console.WriteLine($"{sum} сом. = {Math.Round(result, 2)} эвро");
            }

        }

    }
}
