using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroDeProdutos.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Categoria { get; set; }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        [Required]
        [Range(0.01, 999999.99, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }
    }
}
