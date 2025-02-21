using System;
using System.Collections.Generic;

namespace UnitOfWork.Models;

public partial class Account
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool Status { get; set; }

    public string? SecutiryCode { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
