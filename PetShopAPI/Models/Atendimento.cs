using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopAPI.Models
{
    public class Atendimento
    {
        [Key] // Define como Chave Primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int id_pet { get; set; }
        public Pet Pet { get; set; }
        public int id_cliente { get; set; }
        public Cliente Cliente { get; set; }
        public int? id_funcionario_entrada { get; set; }
        public int? id_funcionario_saida { get; set; }
        public DateTime? entrada { get; set; }
        public DateTime? saida { get; set; }

        // Lista de relacionamentos
        public List<Orcamento> Orcamento { get; set; }
    }
}
