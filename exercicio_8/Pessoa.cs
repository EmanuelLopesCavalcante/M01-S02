
    public class Pessoa
    {
        
public string nome;
public DateTime dataNascimento;


    private int CalcularIdade()
    {
        var dataNascimento = new DateTime(2007, 11, 30);
var dataAtual = DateTime.Now;
var idade = dataAtual.Year - dataNascimento.Year;
if (dataNascimento > dataAtual.AddYears(-idade))
{
 idade--;
}
return idade;
    }


public void MostrarIdade(string nome)
{
    int idade = CalcularIdade();
    Console.WriteLine($"Nome: {nome}, tem a idade de {idade} anos ");
}


    }

