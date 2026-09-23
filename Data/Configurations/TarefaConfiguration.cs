using Lista_de_tarefas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lista_de_tarefas.Data.Configurations
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            //Nome da tabela
            builder.ToTable("tarefas");

            //Mapeando os atributos
            //Id
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            //Id do usuário
            builder.Property(x => x.Id_Usuario)
                .HasColumnName("Id_Usuario");

            //Data de criação
            builder.Property<DateOnly>(x => x.DataCadastro)
                .HasColumnName("Data_Cadastro")
                .HasDefaultValueSql("CURRENT_DATE");

            //Data de expiração
            builder.Property<DateOnly>(x => x.DataExpiracao)
                .HasColumnName("Data_Expiracao")
                .IsRequired();

            //Descrição da tarefa
            builder.Property<string>(x => x.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(200)
                .IsRequired();

            //Prioridade da tarefa
            builder.Property<PRIORIDADE>(x => x.Prioridade)
                .HasColumnName("Prioridade")
                .HasConversion<string>()
                .HasMaxLength(10);

        }
    }
}
