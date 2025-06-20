using System;
namespace Code
{
    public class WordDocumentFactory : DocumentFactory
    {   
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
        
    }
}