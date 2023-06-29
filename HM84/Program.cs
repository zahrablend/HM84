namespace HM84
{
    internal static class Program
    {
        static void Main()
        {
            XmlFileHandler fileHandler = new XmlFileHandler("sample1.xml");

            // Write to XML file
            var note = new Note
            {
                To = "Tove",
                From = "Jani",
                Heading = "Reminder",
                Body = "Don't forget me this weekend!"
            };

            fileHandler.WriteXml(note);

            // Read from XML file
            Note readNote = fileHandler.ReadXml();
            Console.WriteLine($"To: {readNote.To}");
            Console.WriteLine($"From: {readNote.From}");
            Console.WriteLine($"Heading: {readNote.Heading}");
            Console.WriteLine($"Body: {readNote.Body}");

        }
    }
}