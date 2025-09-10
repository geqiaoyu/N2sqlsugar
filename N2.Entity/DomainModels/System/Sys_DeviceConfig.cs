/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using N2.Entity.SystemModels;

namespace N2.Entity.DomainModels
{
    [Entity(TableCnName = "设备配置信息",TableName = "Sys_DeviceConfig")]
    public partial class Sys_DeviceConfig:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
       [Key]
       [Display(Name ="Device_Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Device_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DeviceName")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string DeviceName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PLCName")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string PLCName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IPAddress")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string IPAddress { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Enable")]
       [Column(TypeName="long")]
       [Editable(true)]
       public long? Enable { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DeviceType")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string DeviceType { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrderNo")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrderNo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="DateTime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="DateTime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       
    }
}