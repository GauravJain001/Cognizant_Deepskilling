using System;
namespace Code
{
    public class ExcelDocumentFactory : DocumentFactory
    {   
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
        
    }
}