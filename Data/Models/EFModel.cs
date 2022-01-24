using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SSRNMFSSN.Data.Models
{
    public class EFModel
    {
        private int id;

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get => id; set => id = value; }
    }
}
