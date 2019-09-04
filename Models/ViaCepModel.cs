using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaCEP.Models
{
    public class ViaCepModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        [Required]
        public DateTime DataHora { get; set; }
        [StringLength(200)]
        public string Complemento { get; set; }
        [Required]
        [StringLength(200)]
        public string Logradouro { get; set; }
        [Required]
        [StringLength(200)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(200)]
        public string Localidade { get; set; }
        [Required]
        [StringLength(2)]
        public string Uf { get; set; }
        [Required]
        [StringLength(10)]
        public string Cep { get; set; }
    }
}