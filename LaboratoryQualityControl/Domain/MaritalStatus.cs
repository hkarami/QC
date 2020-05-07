﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("MaritalStatus")]
    public class MaritalStatus : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int MaritalStatusID { get; set; }
        [DisplayName("وضعیت تاهل")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public string MaritalStatusName { get; set; }
        [DisplayName("مرتب")]
        public int InOrder { get; set; }
        [DisplayName("زمان ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
