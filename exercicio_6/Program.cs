public class Filme
{
public string NomeFilme {get; set;}
public string Categoria {get; set;}


public void Retornar(string NomeFilme, string Categoria)
{

Console.WriteLine($"Filme: {NomeFilme}, Categoria: {Categoria}");

}

}