using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200621_오늘도_시작
{
    public class computer
    {
        bool powerOn;
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }
    public class Notebook : computer
    {
        bool fingerScan;
        public bool HasFingerScanDevice()
        {
            return fingerScan;
        }

        public void CloseLid()
        {
            if (powerOn == true)
            {
                Shutdown();
            }
        }
    }
    public class Desktop : computer
    {
   
    }
    public class NetBook : computer
    {
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Boot(); 
        }
    }
}
