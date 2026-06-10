using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroAlunos.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório")]
        [StringLength(10)]
        public string RA { get; set; }

        [Required(ErrorMessage = "O curso é obrigatório")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}