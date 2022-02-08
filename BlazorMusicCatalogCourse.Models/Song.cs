using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMusicCatalogCourse.Models
{
    public class Song
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string Extension { get; set; } = null!;
    }
}
