namespace Lista_de_tarefas.Models
{
    public enum Prioridade
    {
        Baixa,
        Normal,
        Alta
    };
    public class Tarefa
    {
        public int Id { get; set; }
        public int? Id_Usuario { get; set; }
        public string Descricao { get; set; } = String.Empty;
        public DateOnly DataCadastro { get; set; }
        public DateOnly DataExpiracao { get; set; }
        public Prioridade Prioridade { get; set; } = Prioridade.Normal;

    }
}
