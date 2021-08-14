using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace aec_webapi_entity_framework.Models
{
  [Table("usuario")]
  public class Usuario
  {
    [Key]
    [Column("id")]
    public int Id { get;set; }

    [Column("nome", TypeName = "varchar")]
    [Required]
    [MaxLength(150)]
    public string Nome { get;set; }
    
    [Column("cpf", TypeName = "String")]
    [Required]
    [MaxLength(15)]
    public string cpf { get;set; }

    [Column("rg", TypeName = "String")]
    [Required]
    [MaxLength(15)]
    public string rg { get;set; }

    [Column("genero", TypeName = "String")]
    [MaxLength(15)]
    public string genero { get;set; }

    [Column("dataNascimento", TypeName = "DateTime")]
    [Required]
    public string dataNascimento { get;set; }

    [Column("telefone", TypeName = "String")]
    [MaxLength(15)]
    public string telefone { get;set; }

    [Column("telefone2", TypeName = "String")]
    [MaxLength(15)]
    public string telefone2 { get;set; }

    [Column("email", TypeName = "String")]
    [Required]
    [MaxLength(150)]
    public string email { get;set; }

    [Column("profissao", TypeName = "String")]
    [MaxLength(150)]
    public string profissao { get;set; }

    [Column("estadoCivil", TypeName = "String")]
    [MaxLength(150)]
    public string estadoCivil { get;set; }

    [Column("possuiVeiculo", TypeName = "boolean")]
    public string possuiVeiculo { get;set; }

    [Column("possuiHabilitacao", TypeName = "boolean")]
    public string possuiHabilitacao { get;set; }

    


  
  }
}