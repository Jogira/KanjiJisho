using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KanjiJisho.Models;

namespace KanjiJisho.Data
{
    public class KanjiJishoContext : DbContext
    {
        public KanjiJishoContext (DbContextOptions<KanjiJishoContext> options)
            : base(options)
        {
        }

        public DbSet<KanjiJisho.Models.Kanji> Kanji { get; set; } = default!;
    }
}
