using Domains;
using Domains.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models
{
    public class UsuarioInsertViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public Genero Genero { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string? Complemento { get; set; }
        public IFormFile Arquivo { get; set; }
        public ICollection<Tags> Tags { get; set; }
    }
}
