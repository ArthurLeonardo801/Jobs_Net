using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace aec_webapi_entity_framework.Models
{
  [Table("endereco")]
  public class Endereco
  {
    [Key]
    [Column("id")]
    public int Id { get;set; }

    [Column("cep", TypeName = "String")]
    [Required]
    [MaxLength(15)]
    public string cep { get;set; }

    [Column("logradouro", TypeName = "varchar")]
    [Required]
    [MaxLength(150)]
    public string logradouro { get;set; }

    [Column("numero", TypeName = "int")]
    [Required]
    public int numero { get;set; }


    [Column("bairro", TypeName = "String")]
    [Required]
    [MaxLength(150)]
    public string bairro { get;set; }

    [Column("cidade", TypeName = "String")]
    [Required]
    [MaxLength(150)]
    public string cidade { get;set; }

    [Column("pais", TypeName = "String")]
    [Required]
    [MaxLength(150)]
    public string pais { get;set; }

  }
}