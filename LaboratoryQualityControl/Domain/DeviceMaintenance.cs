﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryQualityControl.Domain
{
    [Table("DeviceMaintenance")]
    public class DeviceMaintenance : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("کد")]
        public int DeviceMaintenanceID { get; set; }
        [DisplayName("دستگاه")]
        public int DeviceCode { get; set; }
        [DisplayName("فاکتور(عامل) مورد کنترل")]
        //[StringLength(100)]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد"), StringLength(100)]
        public string ControlledFactor { get; set; }
        [DisplayName("تاریخ")]
        public DateTime DoTime { get; set; }
        [DisplayName("نتیجه")]
        public String Result { get; set; }
        [DisplayName(" کاربر انجام دهنده")]
        public int UserCodeFunctor { get; set; }
        [DisplayName(" کاربر تایید کننده")]
        public int UserCodeConfirm { get; set; }
        [DisplayName("ملاحظات و اقدام اصلاحی")]
        [Required(ErrorMessage = "{0} نمی توان خالی باشد"), StringLength(200)]
        public string RemediesAndCorrectiveAction { get; set; }
        [DisplayName("کد کاربر ثبت کننده")]
        public int UserCode { get; set; }
        [DisplayName("تاریخ آخرین تغییر ")]
        public DateTime UpdateRecordTime { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordTime { get; set; }
        [ForeignKey("UserCode")]
        public virtual User User { get; set; }
        [ForeignKey("UserCodeConfirm")]
        [InverseProperty("ConfirmUserDeviceMaintenances")]
        public virtual User ConfirmUser { get; set; }
        [ForeignKey("UserCodeFunctor")]
        [InverseProperty("FunctorUserDeviceMaintenances")]
        public virtual User FunctorUser { get; set; }
        [ForeignKey("DeviceCode")]
        public virtual Device Device { get; set; }
    }
}
