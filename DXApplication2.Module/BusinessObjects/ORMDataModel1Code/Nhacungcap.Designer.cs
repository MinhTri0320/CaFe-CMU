﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DXApplication2.Module.BusinessObjects.ORMDataModel1
{

    [DefaultProperty("Hoten")]
    public partial class Nhacungcap : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fHoten;
        [DevExpress.Xpo.DisplayName(@"Họ tên")]
        public string Hoten
        {
            get { return fHoten; }
            set { SetPropertyValue<string>(nameof(Hoten), ref fHoten, value); }
        }
        string fDienthoai;
        [DevExpress.Xpo.DisplayName(@"SĐT")]
        public string Dienthoai
        {
            get { return fDienthoai; }
            set { SetPropertyValue<string>(nameof(Dienthoai), ref fDienthoai, value); }
        }
        string fMST;
        public string MST
        {
            get { return fMST; }
            set { SetPropertyValue<string>(nameof(MST), ref fMST, value); }
        }
        [Association(@"PhieunhapReferencesNhacungcap"), Aggregated]
        public XPCollection<Phieunhap> Phieunhaps { get { return GetCollection<Phieunhap>(nameof(Phieunhaps)); } }
        [Association(@"PhieuchiReferencesNhacungcap"), Aggregated]
        public XPCollection<Phieuchi> Phieuchis { get { return GetCollection<Phieuchi>(nameof(Phieuchis)); } }
    }

}
