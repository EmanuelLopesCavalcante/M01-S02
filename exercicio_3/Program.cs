
public class MensagemCelular
{


int telefone;
string mensagem;
//letra minuscula só variavel
public int Telefone { get; set; }
public string Mensagem { get; set; }

public void Executar()
{

    Console.WriteLine($"Método Executado pelo Console");

}


private void EnviarMensagemAoTelefone(int Telefone, string Mensagem)
{

    Console.WriteLine($"Método privado executado na classe");
    Console.WriteLine($"Telefone: {Telefone}, Mensagem: {Mensagem}");


}


public void ExecutarPrivado()
{
    EnviarMensagemAoTelefone(99999999, "Oi, assim que puder, me ligue");
}

}

