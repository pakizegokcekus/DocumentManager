using DocumentManagerBLL;
using BlueLoggingLibrary;
using System;


namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document() { DocumentName = "Deneme1" };

            //document.DocumentName = "İlk versiyon";
            //DocumentCareTaker documentCareTaker = new DocumentCareTaker();
            //;
            //documentCareTaker.DocumentMementos.Add(document.CreateMemento());

            //document.DocumentName = "Pakize";
            //Console.WriteLine(document.DocumentName);

            //document.DocumentName = "Gökçe";
            //Console.WriteLine(document.DocumentName);
            //documentCareTaker.DocumentMementos.Add(document.CreateMemento());

            //document.DocumentName = "";
            //document.LoadDocumentMemonto(documentCareTaker.DocumentMementos[0]);
            //Console.WriteLine(document.DocumentName);
            //document.LoadDocumentMemonto(documentCareTaker.DocumentMementos[1]);
            //Console.WriteLine(document.DocumentName);
            LogInformation _log = new LogInformation
            {
                UserName = "Ali",
                LogMessage = "Hatalı kullanım",
                LogDateTime = "",
                LogLevel = LoggingLevel.Information
            };
            //BlueLoggingLibraryAdapter blueLoggingLibraryAdapter = new BlueLoggingLibraryAdapter();
            LoggerFactoryFile loggerFactory = new LoggerFactoryFile(_log);
            IFactoryFile factory = loggerFactory.GetFactory(LoggerFactoryFile.LogTypes.PdfFileLogger);
            ILoggerFile logger = factory.GetLogger();
            Console.WriteLine(logger.Log());

            Console.ReadKey();
        }
    }
}
