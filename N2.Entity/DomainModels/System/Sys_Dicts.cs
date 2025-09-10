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
    [Entity(TableCnName = "设备字典数据",TableName = "Sys_Dicts")]
    public partial class Sys_Dicts:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
       [Key]
       [Display(Name ="Dic_ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Dic_ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Sort")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string Sort { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Key")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string Key { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Value")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string Value { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Remark")]
       [MaxLength(254)]
       [Column(TypeName="string(254)")]
       [Editable(true)]
       public string Remark { get; set; }

       
    }
}