﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Support: http://www.cnblogs.com/huxj
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace Model
{

    /// <summary>
    /// 实体类TestTable 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TestTable : Entity
    {
        public TestTable() : base("TestTable") { }

        #region Model
        private Guid _Id;
        private string _Name;
        private string _IDNumber;
        private string _MobilePhone;
        private bool? _Test1 = true;
        private int? _Test2 = 50;
        private DateTime _CreateTime;
        /// <summary>
        /// 
        /// </summary>
        public Guid Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange(_.Name, _Name, value);
                this._Name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IDNumber
        {
            get { return _IDNumber; }
            set
            {
                this.OnPropertyValueChange(_.IDNumber, _IDNumber, value);
                this._IDNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MobilePhone
        {
            get { return _MobilePhone; }
            set
            {
                this.OnPropertyValueChange(_.MobilePhone, _MobilePhone, value);
                this._MobilePhone = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? Test1
        {
            get { return _Test1; }
            set
            {
                this.OnPropertyValueChange(_.Test1, _Test1, value);
                this._Test1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Test2
        {
            get { return _Test2; }
            set
            {
                this.OnPropertyValueChange(_.Test2, _Test2, value);
                this._Test2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            get { return _CreateTime; }
            set
            {
                this.OnPropertyValueChange(_.CreateTime, _CreateTime, value);
                this._CreateTime = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.Id};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.Id,
				_.Name,
				_.IDNumber,
				_.MobilePhone,
				_.Test1,
				_.Test2,
				_.CreateTime};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._Id,
				this._Name,
				this._IDNumber,
				this._MobilePhone,
				this._Test1,
				this._Test2,
				this._CreateTime};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._Id = DataUtils.ConvertValue<Guid>(reader["Id"]);
            this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
            this._IDNumber = DataUtils.ConvertValue<string>(reader["IDNumber"]);
            this._MobilePhone = DataUtils.ConvertValue<string>(reader["MobilePhone"]);
            this._Test1 = DataUtils.ConvertValue<bool?>(reader["Test1"]);
            this._Test2 = DataUtils.ConvertValue<int?>(reader["Test2"]);
            this._CreateTime = DataUtils.ConvertValue<DateTime>(reader["CreateTime"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._Id = DataUtils.ConvertValue<Guid>(row["Id"]);
            this._Name = DataUtils.ConvertValue<string>(row["Name"]);
            this._IDNumber = DataUtils.ConvertValue<string>(row["IDNumber"]);
            this._MobilePhone = DataUtils.ConvertValue<string>(row["MobilePhone"]);
            this._Test1 = DataUtils.ConvertValue<bool?>(row["Test1"]);
            this._Test2 = DataUtils.ConvertValue<int?>(row["Test2"]);
            this._CreateTime = DataUtils.ConvertValue<DateTime>(row["CreateTime"]);
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "TestTable");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Id = new Field("Id", "TestTable", "Id");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Name = new Field("Name", "TestTable", "Name");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IDNumber = new Field("IDNumber", "TestTable", "IDNumber");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MobilePhone = new Field("MobilePhone", "TestTable", "MobilePhone");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Test1 = new Field("Test1", "TestTable", "Test1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Test2 = new Field("Test2", "TestTable", "Test2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CreateTime = new Field("CreateTime", "TestTable", "CreateTime");
        }
        #endregion


    }
}

