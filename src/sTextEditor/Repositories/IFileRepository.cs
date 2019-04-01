using System.Threading.Tasks;

namespace sTextEditor.Repositories
{
    public interface IFileRepository
    {
        Task<byte[]> LoadFileAsync(string name);
        Task SaveFileAsync(string name, string fileContent);
    }
}
