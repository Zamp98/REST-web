﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_web.Models {
    public class Cliente {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }
    }
}
