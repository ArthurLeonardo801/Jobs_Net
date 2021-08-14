using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace aec_webapi_entity_framework.Models
{
  [Table("vagas")]
  public class Vagas
  {
    [Key]
    [Column("id")]
    public int Id { get;set; }

    [Column("nome", TypeName = "varchar")]
    [MaxLength(150)]
    [Required]
    public string Nome { get;set; }

    [Column("descricao", TypeName = "text")]
    [Required]    
    public string descricao { get;set; }

   
  }
}