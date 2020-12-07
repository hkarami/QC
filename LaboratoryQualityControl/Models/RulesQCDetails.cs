using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    [Table("RulesQCDetails")]
    public class RulesQCDetails : BaseModel
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
