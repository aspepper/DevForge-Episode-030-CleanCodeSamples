namespace CleanCodeSamples.ConsistentFormatting;

public class ErrorHandling
{
    public void UploadFile(string filePath)
    {
        try
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty", nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found", filePath);
            }

            var fileContent = File.ReadAllText(filePath);
            UploadToServer(fileContent);

            Console.WriteLine("File uploaded successfully");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Log the error or inform the user
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Log the error or inform the user
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            // Log the error or retry the operation
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            // Log the error or take other appropriate action
            throw; // For general excelptions, is important keep it using rethrow
        }
    }

    private void UploadToServer(string content)
    {
        // Logic to upload file content to a server
    }
}