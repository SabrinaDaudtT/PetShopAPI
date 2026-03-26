using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopAPI.Models
{
    public class Orcamento
    {
        [Key] // Define como Chave Primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int id_atendimento { get; set; } // FK para Atendimento
        public Atendimento Atendimento { get; set; }
        public Double valor { get; set; }
        public string? tipo_pagamneto { get; set; }
    }
}
