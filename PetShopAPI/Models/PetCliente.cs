using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopAPI.Models
{
        public class PetCliente
    {
            [Key] // Define como Chave Primária
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public int Id_cliente { get; set; } // FK para Cliente
            public Cliente Cliente { get; set; }
            public int Id_pet { get; set; } // FK para Pet
            public Pet Pet { get; set; }

        }
}
