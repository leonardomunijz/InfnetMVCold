using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Local é obrigatório.")]
        public string Local { get; set; }

        // Relação onde um departamento tem alocado N Funcionários
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
