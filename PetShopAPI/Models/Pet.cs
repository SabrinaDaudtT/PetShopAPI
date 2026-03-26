using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopAPI.Models
{
    public class Pet
    {
        [Key] // Define como Chave Primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string nome { get; set; }
        public string especie { get; set; }
        public string raca { get; set; }
        public DateTime datanascimento {  get; set; }
        public string peso { get; set; }
        public int id_pet_raca { get; set; } // FK para Pet Raça
        public Pet_Raca Pet_Raca { get; set; }
        public int id_pet_tipo { get; set; } // FK para Pet tipo de animal
        public Pet_Tipo Pet_Tipo { get; set; }


        // Lista de relacionamentos
        public List<PetCliente> PetCliente { get; set; }
        public List<Atendimento> Atendimento { get; set; }

    }
}
