using N2.Entity.SystemModels;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2.Entity
{
    [SplitTable(SplitType.Month)]
    [SugarTable("PLCData_{year}{month}{day}")]
    public class PLCData : BaseEntity
    {
        /// <summary>
        ///主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public long Id { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        public string DeviceNO { get; set; }

        /// <summary>
        /// 当前任务 1自动充氮，2气体检测，3气密性检测，4内环流，5排气，6下补气，7上充上排，8停止中，9无任务
        /// </summary>
        public int TaskNo { get; set; }

        /// <summary>
        /// 气密性值
        /// </summary>
        public int Airtightness { get; set; }

        /// <summary>
        /// 氮气浓度1
        /// </summary>
        public float N2Level1 { get; set; }
        /// <summary>
        /// 氮气浓度2
        /// </summary>
        public float N2Level2 { get; set; }
        /// <summary>
        /// 氮气浓度3
        /// </summary>
        public float N2Level3 { get; set; }
        /// <summary>
        /// 氮气浓度4
        /// </summary>
        public float N2Level4 { get; set; }
        /// <summary>
        /// 氮气浓度5
        /// </summary>
        public float N2Level5 { get; set; }

        /// <summary>
        /// 平均氮气浓度
        /// </summary>
        public float AverageN2Level { get; set; }

        /// <summary>
        /// 抽气时间（秒）
        /// </summary>
        public int VCTime { get; set; }

        /// <summary>
        /// 稳定时间（秒）
        /// </summary>
        public int StableTime { get; set; }

        /// <summary>
        /// 稳定时间（秒）
        /// </summary>
        public int TestTime { get; set; }

        /// <summary>
        /// 气压压差
        /// </summary>
        public float Pressure { get; set; }

        /// <summary>
        /// 用电量
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// 目标浓度值
        /// </summary>
        public float TargetLevel { get; set; }
        /// <summary>
        /// 维持负压值
        /// </summary>
        public float WCVC { get; set; }
        /// <summary>
        /// 任务时间
        /// </summary>
        public int TaskTime { get; set; }

        /// <summary>
        /// 抽空负压值
        /// </summary>
        public float CKVC { get; set; }

        /// <summary>
        /// 停止正压值
        /// </summary>
        public float StopPC { get; set; }

        /// <summary>
        /// 风机保护值（分）
        /// </summary>
        public int ProtectionValue { get; set; }

        /// <summary>
        /// 环流时间
        /// </summary>
        public int CMTime { get; set; }

        /// <summary>
        /// 当前氮气值
        /// </summary>
        public int N2Value { get; set; }

        /// <summary>
        /// 氮气浓度校准基数
        /// </summary>
        public float N2LevelBase { get; set; }


        /// <summary>
        /// 阀门组合模式：1内环流，2排气，3下补气，4下充上排，5总关闭
        /// </summary>
        public int ValveModel { get; set; }

        /// <summary>
        /// 手动阀门1开关控制：0停，1开，2关
        /// </summary>
        public int Valve1Switch { get; set; }

        /// <summary>
        /// 手动阀门2开关控制：0停，1开，2关
        /// </summary>
        public int Valve2Switch { get; set; }

        /// <summary>
        /// 手动阀门3开关控制：0停，1开，2关
        /// </summary>
        public int Valve3Switch { get; set; }

        /// <summary>
        /// 手动阀门4开关控制：0停，1开，2关
        /// </summary>
        public int Valve4Switch { get; set; }

        /// <summary>
        /// 手动阀门5开关控制：0停，1开，2关
        /// </summary>
        public int Valve5Switch { get; set; }

        /// <summary>
        /// 阀门1状态 1开到位，2关到位，3执行中，4超时故障
        /// </summary>
        public int Valve1Status { get; set; }
        /// <summary>
        /// 阀门1状态 1开到位，2关到位，3执行中，4超时故障
        /// </summary>
        public int Valve2Status { get; set; }
        /// <summary>
        /// 阀门1状态 1开到位，2关到位，3执行中，4超时故障
        /// </summary>
        public int Valve3Status { get; set; }
        /// <summary>
        /// 阀门1状态 1开到位，2关到位，3执行中，4超时故障
        /// </summary>
        public int Valve4Status { get; set; }
        /// <summary>
        /// 阀门1状态 1开到位，2关到位，3执行中，4超时故障
        /// </summary>
        public int Valve5Status { get; set; }

        /// <summary>
        /// 气泵-手动启停
        /// </summary>
        public int AirPump { get; set; }

        /// <summary>
        /// 风机-手动启停
        /// </summary>
        public int FanManual { get; set; }

        /// <summary>
        /// 氮气仪-手动启停
        /// </summary>
        public int N2Dial { get; set; }

        /// <summary>
        /// 电磁阀1状态
        /// </summary>
        public int SolenoidValve1 { get; set; }

        /// <summary>
        /// 电磁阀2状态
        /// </summary>
        public int SolenoidValve2 { get; set; }

        /// <summary>
        /// 电磁阀3状态
        /// </summary>
        public int SolenoidValve3 { get; set; }

        /// <summary>
        /// 电磁阀4状态
        /// </summary>
        public int SolenoidValve4 { get; set; }

        /// <summary>
        /// 电磁阀5状态
        /// </summary>
        public int SolenoidValve5 { get; set; }

        /// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime { get; set; }

        /// <summary>
		/// 是否删除：0=否，1=是
		/// </summary>
		public bool? IsDelete { get; set; }

        /// <summary>
		/// 删除时间
		/// </summary>
		public DateTime? DeleteTime { get; set; }
    }

    public class PageData
    {
        public int DeviceID { get; set; }
        public int type { get; set; }
        public int parp { get; set; }
    }

    public class PagePLCData
    {
        public int DeviceID { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
    }

    public class PageData1
    {
        public int DeviceID { get; set; }
        public int type { get; set; }
        public string parp { get; set; }
    }
}
