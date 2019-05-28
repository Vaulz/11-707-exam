using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharing.Models
{
    public class FileModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string ShortURL { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }

        public FileModel(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public FileModel()
        {
        }
    }
}
