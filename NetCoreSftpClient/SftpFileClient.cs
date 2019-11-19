using Renci.SshNet;

public static class SftpFileClient
{
    private static string host = "10.0.0.15";
    private static string username = "pi";
    private static int port = 22;
    private static string privateKeyFileName = "C:\\Users\\Esc Group - Eneudy\\.ssh\\id_rsa";
    private static string remotePath = "/home/pi/Desktop/lab07";

    public static int Send(string fileName)
    {    
        using (var sftp = new SftpClient(host, port, username, new PrivateKeyFile(privateKeyFileName))){
            sftp.Connect();
            sftp.ChangeDirectory(remotePath);
            using (var uplfileStream = System.IO.File.OpenRead(fileName)){
                sftp.UploadFile(uplfileStream, fileName, true);
            }
            sftp.Disconnect();
        }
        return 0;
    }
}
