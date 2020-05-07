using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("RulesQCDetails")]
    public class RulesQCDetails : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RulesQCDetailsID { get; set; }
        public byte RulesQCID { get; set; }
        [DisplayName("دسته")]
        [StringLength(50)]
        public string Name { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        public virtual RulesQC RulesQC { get; set; }
    }
}
