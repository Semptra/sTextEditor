using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sTextEditor.Models.Converters
{
    public static class FileInfoConverter
    {
        public static FileInfoDataGridModel ConvertFromDbModel(FileInfoDbModel fileInfoDbModel)
        {
            return new FileInfoDataGridModel
            {
                Id = fileInfoDbModel.Id,
                Name = fileInfoDbModel.Name,
                LastModifiedDate = fileInfoDbModel.LastModifiedDate
            };
        }
    }
}
