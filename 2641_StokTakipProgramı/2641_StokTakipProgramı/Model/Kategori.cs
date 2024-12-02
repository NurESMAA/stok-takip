using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2641_StokTakipProgramı.Model
{
    public class Kategori
    {
        public int Id { get; set; }


        public string Kategoriadi { get; set; }

        // İlişki : Bir kategorinin birden fazla ürüne sahip olabilir.

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
