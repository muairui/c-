//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_FIA8K_SamplePeak
    {
        public long ID { get; set; }
        public Nullable<long> SAMPLEID { get; set; }
        public Nullable<int> TESTTIMENO { get; set; }
        public Nullable<double> OUTPUTSTARTTIME { get; set; }
        public Nullable<double> INTEGRALSTARTTIME { get; set; }
        public Nullable<double> INTEGRALENDTIME { get; set; }
        public Nullable<double> CONCENTRATION { get; set; }
        public Nullable<double> CONCENTRATIONDEVIATION { get; set; }
        public Nullable<double> ADDBASEAMOUNT { get; set; }
        public Nullable<double> CALCCONCENTRATION { get; set; }
        public Nullable<double> PEAKHEIGHT { get; set; }
        public Nullable<double> PEAKAREA { get; set; }
        public Nullable<int> STATE { get; set; }
        public Nullable<int> NEEDLECLEANTIME { get; set; }
        public Nullable<int> ARRIVALTIME { get; set; }
        public Nullable<int> INJECTTIME { get; set; }
        public Nullable<int> INJECTTIME2 { get; set; }
        public Nullable<int> CLEANTIME { get; set; }
        public Nullable<int> CYCLETIME { get; set; }
        public Nullable<double> PEAKTIME { get; set; }
        public Nullable<double> INTEGRALWIDTH { get; set; }
        public Nullable<int> INTEGRALAREASTARTTIME { get; set; }
        public Nullable<int> INTEGRALAREAWIDTH { get; set; }
        public string REMARK { get; set; }
        public string INSERTUSER { get; set; }
        public Nullable<System.DateTime> INSERTDATETIME { get; set; }
        public string UPDATEUSER { get; set; }
        public Nullable<System.DateTime> UPDATEDATETIME { get; set; }
    }
}
