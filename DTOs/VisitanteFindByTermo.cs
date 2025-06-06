using System;
using System.Collections.Generic;
using System.Text;

namespace AppSharedProject.DTOs
{
    public class VisitanteFindByTermo
    {
        public string Termo { get; set; }
        public VisitanteFindByTermoType Tipo { get; set; }
    }
    public enum VisitanteFindByTermoType           
    {
        Nome,
        Documento,
        Empresa,
        Placa,
        Cpf
    }
}
