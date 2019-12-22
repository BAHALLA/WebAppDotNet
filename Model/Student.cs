using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppDotNet.Model{
    public class Student {
         [Key]
         public long Id { get; set; }
         [Required, StringLength(25)]
         public string Name { get; set; }
         public int Score { get; set; }
    }
}