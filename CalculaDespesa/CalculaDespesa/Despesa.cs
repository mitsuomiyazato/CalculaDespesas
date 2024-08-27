namespace CalculaDespesa;

public class Despesa
{
    private List<Item> _listaLucro = new List<Item>();
    private List<Item> _listaDespesa = new List<Item>();
    private double _totalLucro = 0;
    private double _totalDespesa = 0;
    private double _totalSaldo;
    
    public void addItemList(Item item){
        if(item.Tipo.Equals("Lucro")){
            _listaLucro.Add(item);
        }
        else
        {
        _listaDespesa.Add(item);
        }
        calculaTotalSaldo();
    }

    public void calculaTotalLucro(){
        _totalLucro = 0;
        foreach(Item item in _listaLucro)
        {
            _totalLucro += item.Valor;
        }
    }

    private void calculaTotalDespesa(){
        _totalDespesa = 0;
        foreach(Item item in _listaDespesa){
            _totalDespesa += item.Valor;
        }
    }

    private void calculaTotalSaldo(){
        calculaTotalLucro();
        calculaTotalDespesa();
        _totalSaldo = _totalLucro - _totalDespesa;
    }

    public List<Item> ListaLucro{
        get{return _listaLucro;}
    }
    public List<Item> ListaDespesa{
        get{return _listaDespesa;}
    }
    public double TotalSaldo{
        get{return _totalSaldo;}
    }
}
