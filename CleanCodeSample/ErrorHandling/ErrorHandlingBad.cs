namespace CleanCodeSamples.ConsistentFormatting;

public class ErrorHandlingBad
{
    public void UploadFileBad(string filePath)
    {
        // Attempting to open the file without checking if the file exists or if the path is valid
        var fileContent = File.ReadAllText(filePath);

        // Attempting to upload the file content to a server
        UploadToServer(fileContent);

        Console.WriteLine("File uploaded successfully");
    }

    private void UploadToServer(string content)
    {
        // Logic to upload file content to a server
    }
}
