using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool Type { get; set; }
        public int? FkPessoa { get; set; }

        public virtual Pessoa? FkPessoaNavigation { get; set; }
    }
}
