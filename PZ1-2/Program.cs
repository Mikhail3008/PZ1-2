using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PZ1_2
{
    internal class Program
    {
        public double _first;
        public int _second;
        double price;
        public Program(double first, int second)
        {
            _first = first;
            _second = second;
        }
        public Program()
        {

        }
        
        public double First
        {
            get { return _first; }
            set 
            { 
                if (value > 0)
                    _first = value;
            }
        }
        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                if(value>0)
                    _second = value;
            }
        }
        public void cost()
        {
            price = _second * _first;
        }
        
       
        public void Read()
        {
            _first=Convert.ToDouble(Console.ReadLine());
            _second=Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Program a= new Program();
            a.Read();
            a.cost();
            a.Display();
            Console.ReadKey();
        }
        public void Display()
        {
            Console.WriteLine($"цена товара {_first} \nколичество товара {_second} \nстоимость всего товара {price}");
        }
    }
}
