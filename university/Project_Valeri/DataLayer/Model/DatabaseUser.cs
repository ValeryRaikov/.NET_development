using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project_Valeri.Model;
using Project_Valeri.Others;

namespace DataLayer.Model
{
    public class DatabaseUser : User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get => base.Id; set => base.Id = value; }

        public DatabaseUser() : base("", "", UserRolesEnum.STUDENT, "") { }
    }
}
