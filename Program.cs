using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergePdfWithTelerik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath1 = @"C:/Users/Muham/Downloads/TourConfirmation.pdf";
            string filePath2 = @"C:/Users/Muham/Downloads/Terms & Conditions.pdf";
            string outFilePath = @"C:/Users/Muham/Downloads/MergeFile.pdf";
            PdfMerge pdfMerge = new PdfMerge(); 
            pdfMerge.MergePdf(filePath1, filePath2 , outFilePath);
            Console.WriteLine("Merged");
            Console.ReadLine();
        }
    }
}
