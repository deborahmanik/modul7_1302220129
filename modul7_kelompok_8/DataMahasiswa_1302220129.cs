using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    internal class DataMahasiswa_1302220129
    {
        public DataMahasiswa ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string jsonString = File.ReadAllText(path + "jurnal7_1_1302220129.json");
            return JsonSerializer.Deserialize<DataMahasiswaNIM>(jsonString);
        }
    }
}
