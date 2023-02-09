using Aspose.OCR;
using asprise_ocr_api;
using IronOcr;
using Patagames.Ocr;

namespace OCR
{
    internal class Program
    {
        static void Main()
        {
            Program p = new Program();
            p.ReadData();
            Console.Read();
        }
        public void ReadData()
        {
            try
            {
                using (var objOcr = OcrApi.Create())
                {
                    objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                    string plaintext = objOcr.GetTextFromImage("C:\\Users\\Syed Jibraan Ahmed\\Downloads\\Skype Downloads\\download.jpg");

                    Console.WriteLine(plaintext);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //public void ReadImage()
        //{
        //    try
        //    {

        //        //AsposeOcr api = new AsposeOcr();
        //        //string result = api.RecognizeImage("C:\\Users\\Syed Jibraan Ahmed\\Pictures\\Screenshots\\img.jpg");
        //        IronOcr.Installation.LicenseKey = "IRONOCR-MYLICENSE-KEY-1EF01";
        //        string Text = new IronTesseract().Read(@"C:\\Users\\Syed Jibraan Ahmed\\Pictures\\Screenshots\\img.jpg").Text;
        //        Console.WriteLine(Text);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public void ImageReader()
        //{
        //    try
        //    {
        //        var Ocr = new IronTesseract(); // nothing to configure
        //        Ocr.Language = OcrLanguage.English;
        //        Ocr.Configuration.TesseractVersion = TesseractVersion.Tesseract5;
        //        using (var Input = new OcrInput())
        //        {
        //            Input.AddImage(@"C:\\Users\\Syed Jibraan Ahmed\\Pictures\\Screenshots\\img.jpg");
        //            var Result = Ocr.Read(Input);
        //            Console.WriteLine(Result.Text);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public void ImageText()
        //{
        //    try
        //    {
        //        AspriseOCR.SetUp();
        //        AspriseOCR ocr = new AspriseOCR();
        //        ocr.StartEngine("eng", AspriseOCR.SPEED_FASTEST);
        //        string s = ocr.Recognize("C:\\Users\\Syed Jibraan Ahmed\\Pictures\\Screenshots\\img.png", -1, -1, -1, -1, -1, AspriseOCR., AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);

        //        Console.WriteLine(s);

        //        ocr.StopEngine();

        //        var Ocr = new IronTesseract(); // nothing to configure
        //        Ocr.Language = OcrLanguage.EnglishBest;
        //        Ocr.Configuration.TesseractVersion = TesseractVersion.Tesseract5;
        //        using (var Input = new OcrInput())
        //        {
        //            Input.AddImage(@"C:\\Users\\Syed Jibraan Ahmed\\Pictures\\Screenshots\\img.png");
        //            var Result = Ocr.Read(Input);
        //            Console.WriteLine(Result.Text);
        //            Console.ReadKey();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);

        //    }
        //}



    }
}