using System.ComponentModel.DataAnnotations;

namespace Capitani.Domain.Entities
{
    public class EstadoCivilEntityViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
