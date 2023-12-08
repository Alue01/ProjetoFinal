using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalAlue.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Colaborador> Colaborador { get; set; }

        public DbSet<Estado> Estado { get; set; }

        public DbSet<LocalRealizacao> LocalRealizacao { get; set; }

        public DbSet<Procedimentos> Procedimentos { get; set; }

        public DbSet<ProcedimentoRealizado> ProcedimentoRealizado { get; set; }

        public DbSet<TipoColaborador> TipoColaborador { get; set; }

        public DbSet<TipoProcedimento> TipoProcedimento { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
