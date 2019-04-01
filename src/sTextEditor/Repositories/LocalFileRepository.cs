using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace sTextEditor.Repositories
{
    public class LocalFileRepository : IFileRepository
    {
        public async Task<byte[]> LoadFileAsync(string name)
        { 
            using (var fileStream = File.Open(name, FileMode.Open))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                var fileContentBuffer = new byte[fileStream.Length];
                await fileStream.ReadAsync(fileContentBuffer, 0, (int)fileStream.Length);
                return fileContentBuffer;
            }
        }

        public async Task SaveFileAsync(string name, string fileContent)
        {
            using (var fileStream = File.Open(name, FileMode.Create))
            using (var streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
            {
                await streamWriter.WriteAsync(fileContent);
            }
        }
    }
}
