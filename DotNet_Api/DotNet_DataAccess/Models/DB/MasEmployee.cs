using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNet_DataAccess.Models.DB;

[Table("MAS_Employee")]
public partial class MasEmployee
{
    [Key]
    [Column("EmpID")]
    public int EmpId { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string? Surname { get; set; }

    [StringLength(500)]
    public string? Fname { get; set; }

    [StringLength(100)]
    public string? Telephone { get; set; }

    [Column("RoleID")]
    public int? RoleId { get; set; }

    [StringLength(500)]
    public string? Email { get; set; }

    [StringLength(100)]
    public string? UserName { get; set; }

    [MaxLength(128)]
    public byte[]? Password { get; set; }

    [StringLength(1000)]
    public string? Remark { get; set; }

    public byte? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("LastEditPWD", TypeName = "datetime")]
    public DateTime? LastEditPwd { get; set; }

    public int? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDateTime { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDateTime { get; set; }

    [StringLength(50)]
    public string? DelFlag { get; set; }
}
