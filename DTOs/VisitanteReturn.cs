using System;
using System.Collections.Generic;
using System.Text;

namespace AppSharedProject.DTOs
{
    public class VisitanteReturn
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Documento { get; set; }
        public string? Empresa { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Placa { get; set; }
        public string? Cpf { get; set; }
    }
}
