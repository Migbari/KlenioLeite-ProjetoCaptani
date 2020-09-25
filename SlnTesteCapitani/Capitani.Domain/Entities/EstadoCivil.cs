using System.ComponentModel.DataAnnotations;

namespace Capitani.Domain.Entities
{
    public class EstadoCivil
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
