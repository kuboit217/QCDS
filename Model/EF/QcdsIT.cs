namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QcdsIT")]
    public partial class QcdsIT
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string Khoi { get; set; }

        [StringLength(50)]
        public string BoPhan { get; set; }

        [StringLength(50)]
        public string BanLa { get; set; }

        [StringLength(50)]
        public string BaoLau { get; set; }

        [StringLength(50)]
        public string LienLac { get; set; }

        [StringLength(50)]
        public string ThoiGianA { get; set; }

        [StringLength(50)]
        public string ThoiGianB { get; set; }

        [StringLength(50)]
        public string ThoiGianC { get; set; }

        [StringLength(50)]
        public string ThoiGianD { get; set; }

        [StringLength(50)]
        public string SuCoA { get; set; }

        [StringLength(50)]
        public string SuCoB { get; set; }

        [StringLength(50)]
        public string SuCoC { get; set; }

        [Column(TypeName = "ntext")]
        public string YKien { get; set; }

        public int? UserName { get; set; }
    }
}
