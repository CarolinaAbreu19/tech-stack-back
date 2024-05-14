namespace TechStackProcesso.Models
{
    public class AreaConhecimento
    {
        public int Id { get; set; }
        public int IdTechStack { get; set; }
        public int IdTipoConhecimento { get; set; }
        public string Descricao { get; set; }
    }
}
