namespace BibliotecaApi.Models;

/// <summary>
/// Representa uma resposta paginada de uma lista de itens.
/// </summary>
/// <typeparam name="T">Tipo dos itens retornados.</typeparam>
public class RespostaPaginada<T>
{
    /// <summary>
    /// Lista de itens da página atual.
    /// </summary>
    public List<T> Itens { get; set; } = new();

    /// <summary>
    /// Número da página atual.
    /// </summary>
    /// <example>1</example>
    public int Pagina { get; set; }

    /// <summary>
    /// Quantidade de itens por página (máximo 50).
    /// </summary>
    /// <example>10</example>
    public int TamanhoPagina { get; set; }

    /// <summary>
    /// Total de itens existentes no acervo.
    /// </summary>
    /// <example>42</example>
    public int TotalItens { get; set; }

    /// <summary>
    /// Total de páginas disponíveis.
    /// </summary>
    /// <example>5</example>
    public int TotalPaginas => (int)Math.Ceiling((double)TotalItens / TamanhoPagina);
}