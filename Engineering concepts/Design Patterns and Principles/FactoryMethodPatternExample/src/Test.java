public class Test {
    public static void main(String[] args) {
        //creating WordDocument
        DocumentFactory wordDocumentFactory = new WordDocumentFactory();
        Document wordDocument = wordDocumentFactory.createDocument();
        wordDocument.info();

        //creating ExcelDocument
        DocumentFactory excelDocumentFactory = new ExcelDocumentFactory();
        Document excelDocument = excelDocumentFactory.createDocument();
        excelDocument.info();

        //creating PdfDocument
        DocumentFactory pdfDocumentFactory = new PdfDocumentFactory();
        Document pdfDocument = pdfDocumentFactory.createDocument();
        pdfDocument.info();
    }
}
