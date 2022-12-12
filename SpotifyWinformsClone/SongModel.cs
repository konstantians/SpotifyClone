using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SongModel
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string Description { get; set; }
        public int  Price { get; set; }
        public string FilePath { get; set; }
    }
}
