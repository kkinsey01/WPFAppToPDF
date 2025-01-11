using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using WPFAppToPDF.Classes;

namespace WPFAppToPDF;

public class ConvertFormToPDF
{
    private readonly FormEntry _formEntry;

    public ConvertFormToPDF(FormEntry formEntry)
    {
        _formEntry = formEntry;
    }

    public void ConvertForm()
    {
        PdfDocument document = new PdfDocument();

        PdfPage page = document.AddPage();

        XGraphics gfx = XGraphics.FromPdfPage(page);

        XFont font = new XFont("Verdana", 20, XFontStyleEx.Bold);

        int y = 0;

        gfx.DrawString($"Name: {_formEntry.Name}", font, XBrushes.Black, new XRect(0, y, page.Width, 0), XStringFormats.TopLeft);

        y += font.Height;

        gfx.DrawString($"Address: {_formEntry.Address}", font, XBrushes.Black, new XRect(0, y, page.Width, 0), XStringFormats.TopLeft);

        y += font.Height;

        gfx.DrawString($"Email: {_formEntry.Email}", font, XBrushes.Black, new XRect(0, y, page.Width, 0), XStringFormats.TopLeft);

        string fileName = "ConvertedForm.pdf";

        document.Save(fileName);        
    }
}
