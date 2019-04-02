using System;

namespace sTextEditor.Models
{
    public class FileInfoDbModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
