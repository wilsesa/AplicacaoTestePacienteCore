using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoTestePacienteCore.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Prontuario é obrigátorio")]
        public int Prontuario { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigátorio")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo sobrenome é obrigátorio")]
        [MaxLength(100)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo data de nascimento é obrigátorio")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo género é obrigátorio")]
        [MaxLength(20)]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigátorio")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo email é obrigátorio")]
        [MaxLength(20)]
        [EmailAddress(ErrorMessage ="O email não é válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo celular é obrigátorio")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Campo telefone fixo é obrigátorio")]
        public string TelFixo { get; set; }

        [Required(ErrorMessage = "Campo convenio é obrigátorio")]
        [MaxLength(20)]
        public string Convenio { get; set; }

        [Required(ErrorMessage = "Campo carterinha é obrigátorio")]
        public string Carterinha { get; set; }

        [Required(ErrorMessage = "Campo validade é obrigátorio")]
        [DataType(DataType.Date)]
        public DateTime Validade { get; set; }

        [Required(ErrorMessage = "Campo Prontuario é obrigátorio")]
        public bool Estado { get; set; }
    }
}
