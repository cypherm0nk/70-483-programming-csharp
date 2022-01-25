using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_33_IPrintable_interface
{
    interface IPrintable
    {
        string GetPrintableText(int pageWidth, int pageHeight);
        string GetTitle();
    }
    interface IDisplay
    {
        string GetTitle();
    }

    class Report : IPrintable
    {
        string IPrintable.GetPrintableText(int pageWidth, int pageHeight)
        {
            return "Report text";
        }
        string IPrintable.GetTitle()
        {
            return "Raport title ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
