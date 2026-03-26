using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopAPI.Models
{
    public class Funcionario
    {
        [Key] // Define como Chave Primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public string? email { get; set; }
        public string? telefone { get; set; }
        public string? endereco { get; set; }
        public string? cidade { get; set; }
        public string? bairro { get; set; }
        public int? numero { get; set; }
        public DateTime dataAdmissao { get; set; }
        public DateTime? dataDemissao { get; set; }
        public string? cargo { get; set; }
        public string funcao { get; set; }

        // Lista de relacionamentos
        public List<Atendimento> Atendimento { get; set; }
    } 
}
