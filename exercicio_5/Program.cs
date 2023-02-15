public class Cobrar
{

private decimal valor;
private decimal multa;

public void Preencher(decimal Valor, decimal Multa)
{

valor = Valor;
multa = Multa;

}

private decimal CobrarMulta()
{

return valor + multa;

}

public void Calcular()
{

CobrarMulta();
Console.WriteLine("------------------------------------------------------");
Console.WriteLine($"|| Valor Cobrado: {valor}, Multa: {multa}, Soma Valor: {valor + multa}. ||");
Console.WriteLine("------------------------------------------------------");
}
}