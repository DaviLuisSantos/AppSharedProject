using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppSharedProject.DTOs;

public class VisitanteCreateDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string? Documento { get; set; }
    public string? Empresa { get; set; }
    public string? Endereco { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public string? Placa { get; set; }
    public string? CarroCor { get; set; }
    public string? CarroMarca { get; set; }
    public string? Foto1 { get; set; }
    public string? Foto2 { get; set; }
    public string? Foto3 { get; set; }
    public string? Foto4 { get; set; }
    public string OperadorCadastro { get; set; }
    public DateTime? PrimeiraVisita { get; set; }
    public DateTime? UltimaVisita { get; set; }
    public string? CorCarroVisita { get; set; }
    public string? Observacao { get; set; }
    public string? UltimaUnidadeVisitada { get; set; }
    public string? Celular { get; set; }
    public string? Cpf { get; set; }
    public DateTime? DataCadastro { get; set; }
    public string TipoVisitante { get; set; }
    public DateTime? UltimoAcesso { get; set; }
}
