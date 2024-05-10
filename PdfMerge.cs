using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Documents.Primitives;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Streaming;

namespace MergePdfWithTelerik
{
    public class PdfMerge
    {

        public void MergePdf(string FilePathOne, string FilePathTwo, string MergeFilePath) {
            string firstDocument = FilePathOne;
            string secondDocument = FilePathTwo;

            string exportedPdf = MergeFilePath;
            if (File.Exists(exportedPdf))
            {
                File.Delete(exportedPdf);
            }

            using (FileStream fileStream = File.OpenWrite(exportedPdf))
            {
                using (PdfStreamWriter fileWriter = new PdfStreamWriter(fileStream))
                {
                    using (PdfFileSource firstDocumentToMerge = new PdfFileSource(File.OpenRead(firstDocument)))
                    using (PdfFileSource secondDocumentToMerge = new PdfFileSource(File.OpenRead(secondDocument)))
                    {
                        foreach (var page in firstDocumentToMerge.Pages)
                        {
                            fileWriter.WritePage(page);
                        }
                        foreach(var page in secondDocumentToMerge.Pages)
                        {
                            fileWriter.WritePage(page);
                        }
                        
                    }
                }
            }

        }

       
      

    }
}
