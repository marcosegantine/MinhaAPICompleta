﻿using DevIO.Business.Models.Validations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.Models
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campor {0} é obrigatório")]
        [StringLength(100, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        public int TipoFornecedor { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}
