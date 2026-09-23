namespace Lista_de_tarefas.Models
{
    public enum PRIORIDADE
    {
        baixa,
        normal,
        alta
    };
    public class Tarefa
    {
        public int Id { get; set; }
        public int? Id_Usuario { get; set; }
        public string Descricao { get; set; } = String.Empty;
        public DateOnly DataCadastro { get; set; }
        public DateOnly DataExpiracao { get; set; }
        public PRIORIDADE Prioridade { get; set; } = PRIORIDADE.normal;

    }
}
