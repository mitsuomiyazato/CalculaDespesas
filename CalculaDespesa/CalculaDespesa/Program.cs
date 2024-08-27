using CalculaDespesa;

Despesa despesa = new Despesa();

Console.WriteLine("*DESPESAS*");

Item item1 = new Item("VR", 116.72, 0);
Item item2 = new Item("Fim de semana", 90, 1);
Item item3 = new Item("Banco", 1333.42, 0);
Item item4 = new Item("Condomínio", 850, 1);
Item item5 = new Item("Fim de semana", 90, 1);

despesa.addItemList(item1);
despesa.addItemList(item2);
despesa.addItemList(item3);
despesa.addItemList(item4);
despesa.addItemList(item5);

Console.WriteLine("\nLucro-->");
foreach(Item item in despesa.ListaLucro)
{
    Console.WriteLine("{0}: +R$ {1:f2}", item.Nome, item.Valor);
}

Console.WriteLine("\nDespesa-->");
foreach(Item item in despesa.ListaDespesa)
{
    Console.WriteLine("{0}: -R$ {1:f2}", item.Nome, item.Valor);
}

Console.WriteLine("\nSaldo: R$ {0:f2}", despesa.TotalSaldo);
