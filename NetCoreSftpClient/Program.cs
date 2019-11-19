using System;

namespace NetCoreSftpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "tss.json";
            SftpFileClient.Send(fileName);
            Console.WriteLine("File uploaded");
        }
    }
}
