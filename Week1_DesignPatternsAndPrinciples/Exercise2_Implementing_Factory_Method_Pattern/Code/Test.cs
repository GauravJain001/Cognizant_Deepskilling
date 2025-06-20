using System;
namespace Code
{
    public class Test
    {
        public static void Main(String[] args)
        {
            // creating Instance of Factories
            DocumentFactory excelFactory = new ExcelDocumentFactory();
            DocumentFactory pdfFactory = new PdfDocumentFactory();
            DocumentFactory wordFactory = new WordDocumentFactory();
            // creating Instance of Documents using Factories
            IDocument excelDocument = excelFactory.CreateDocument();
            IDocument pdfDocument = pdfFactory.CreateDocument();
            IDocument wordDocument = wordFactory.CreateDocument();
            // calling Type method of Documents
            excelDocument.Type();
            pdfDocument.Type();
        }
    }
}