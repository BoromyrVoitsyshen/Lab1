using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

/// <summary>
/// Books that are currently borrowed
/// </summary>
public partial class BorrowedBook : Entity
{
    [Display(Name = "Книга")]
    public int BookId { get; set; }
    [Display(Name = "Читач")]
    public int ReaderId { get; set; }
    [Required(ErrorMessage = "Поле має бути не порожнім")]
    [Display(Name = "Початок позичення")]
    public int BorrowStart { get; set; }
    [Required(ErrorMessage = "Поле має бути не порожнім")]
    [Display(Name = "Термін позичення")]
    public int BorrowTime { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Reader Reader { get; set; } = null!;
}
