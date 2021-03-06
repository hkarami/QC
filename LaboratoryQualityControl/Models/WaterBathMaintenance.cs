﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models.Devices;

namespace LaboratoryQualityControl.Models
{
    [Table("WaterBathMaintenance")]
    public class WaterBathMaintenance : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int WaterBathMaintenanceID { get; set; }
        [DisplayName("کد دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName("تاریخ")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        public DateTime DoTime { get; set; }
        [DisplayName("کاربر انجام دهنده")]
        public int UserCodeFunctor { get; set; }
        [DisplayName("دما")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد")]
        [Range(0, 100, ErrorMessage = " {0} مقدار بین {0} و  ")]
        public byte Temperatures { get; set; }
        [DisplayName("تعویض آب")]
        public bool WaterExchange { get; set; }
        [DisplayName("رسوب گیری")]
        public bool Sedimentation { get; set; }
        [DisplayName("نظافت ")]
        public bool Clean { get; set; }
        [DisplayName("کاربر تایید کننده")]
        public int UserCodeConfirm { get; set; }
        [DisplayName("ملاحظات")]
        [StringLength(200)]
        public string Description { get; set; }
        [DisplayName("کاربر ثبت کننده")]
        public int UserCode { get; set; }
        [DisplayName("تاریخ آخرین تغییر")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("تاریخ ثبت رکورد")]
        public DateTime RecordTime { get; set; }
        public virtual DeviceModel Device { get; set; } 
        [ForeignKey("UserCodeFunctor")]
        [InverseProperty("UserFunctorWaterBathMaintenance")]
        public virtual UserModel UserFunctor { get; set; }
        [ForeignKey("UserCodeConfirm")]
        [InverseProperty("UserConfirmWaterBathMaintenance")]
        public virtual UserModel UserConfirm { get; set; }
        public virtual UserModel User { get; set; }
    }
}
