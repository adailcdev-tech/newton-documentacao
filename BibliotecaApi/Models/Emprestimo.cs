using System.ComponentModel.DataAnnotations;

namespace BibliotecaApi.Models;

/// <summary>
/// Representa um empréstimo de livro realizado na biblioteca.
/// </summary>
public class Emprestimo
{
    /// <summary>
    /// Identificador único do empréstimo.
    /// </summary>
    /// <example>1</example>
    public int Id { get; set; }

    /// <summary>
    /// Identificador do livro emprestado.
    /// </summary>
    /// <example>1</example>
    [Required]
    public int LivroId { get; set; }

    /// <summary>
    /// Nome do usuário que realizou o empréstimo.
    /// </summary>
    /// <example>João Silva</example>
    [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
    [StringLength(200)]
    public string NomeUsuario { get; set; } = string.Empty;

    /// <summary>
    /// Data em que o empréstimo foi realizado.
    /// </summary>
    /// <example>2026-04-25T10:00:00Z</example>
    public DateTime DataEmprestimo { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Data prevista para devolução do livro (14 dias após o empréstimo).
    /// </summary>
    /// <example>2026-05-09T10:00:00Z</example>
    public DateTime DataDevolucaoPrevista { get; set; } = DateTime.UtcNow.AddDays(14);

    /// <summary>
    /// Data em que o livro foi efetivamente devolvido. Nulo se ainda não devolvido.
    /// </summary>
    /// <example>null</example>
    public DateTime? DataDevolucaoEfetiva { get; set; }

    /// <summary>
    /// Status atual do empréstimo.
    /// </summary>
    /// <example>Ativo</example>
    public StatusEmprestimo Status { get; set; } = StatusEmprestimo.Ativo;
}

/// <summary>
/// Status possíveis de um empréstimo.
/// </summary>
public enum StatusEmprestimo
{
    /// <summary>Empréstimo em andamento.</summary>
    Ativo,
    /// <summary>Livro já devolvido.</summary>
    Devolvido,
    /// <summary>Prazo de devolução ultrapassado.</summary>
    Atrasado
}