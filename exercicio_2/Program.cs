public class FichaInscricao
{

public int Id { get; set; }
public string Nome { get; set; }
public bool MenorIdade { get; set; }
DateTime dataNascimento = new DateTime (2007, 11, 30);
    
public void EscreverOConsole(int Id, string Nome, bool MenorIdade)
{

Console.WriteLine($"Idade: {Id}, Nome: {Nome}, Data Nascimento: {dataNascimento}, Menor idade: {MenorIdade}");

}

}