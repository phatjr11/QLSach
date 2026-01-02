namespace QLSach.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [Key]
        public int MaPM { get; set; }

        [Required]
        [StringLength(6)]
        public string MaDG { get; set; }

        [Required]
        [StringLength(6)]
        // Using FixedLength char(6) in DB, mapped here as string
        public string MaSach { get; set; }

        public DateTime NgayMuon { get; set; }

        public DateTime? NgayTra { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }
        
        // DaTra is bit -> bool
        public bool DaTra { get; set; }

        public virtual DocGia DocGia { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
