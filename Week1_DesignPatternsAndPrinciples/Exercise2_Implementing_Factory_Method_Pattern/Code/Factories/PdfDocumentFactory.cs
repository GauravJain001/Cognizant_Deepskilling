using System;
namespace Code
{
    public class PdfDocumentFactory : DocumentFactory
    {   
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
        
    }
}