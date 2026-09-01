// rev-a2b81d-20260901 PDFConverter.cs
﻿using System.IO;
using Aspose.Pdf;

public class PDFConverter {
    public void ConvertToWord(string pdfPath, string outputPath) {
        Document pdfDocument = new Document(pdfPath);
        DocSaveOptions saveOptions = new DocSaveOptions();
        saveOptions.Format = DocSaveOptions.DocFormat.DocX;
        saveOptions.Mode = DocSaveOptions.RecognitionMode.Flow;
        
        pdfDocument.Save(outputPath, saveOptions);
    }
    
    public void ConvertToExcel(string pdfPath, string outputPath) {
        Document pdfDocument = new Document(pdfPath);
        ExcelSaveOptions saveOptions = new ExcelSaveOptions();
        saveOptions.MinimizeTheNumberOfWorksheets = true;
        
        pdfDocument.Save(outputPath, saveOptions);
    }
    
    public void CompressPDF(string inputPath, string outputPath, int quality) {
        Document pdfDocument = new Document(inputPath);
        
        var optimizeOptions = new Pdf.Optimization.OptimizationOptions();
        optimizeOptions.ImageCompressionOptions.CompressImages = true;
        optimizeOptions.ImageCompressionOptions.ImageQuality = quality;
        
        pdfDocument.OptimizeResources(optimizeOptions);
        pdfDocument.Save(outputPath);
    }
}
