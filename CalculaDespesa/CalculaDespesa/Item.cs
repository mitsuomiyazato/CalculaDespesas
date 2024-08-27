namespace CalculaDespesa;

public class Item
{
    private String _nome;
    private double _valor;
    private int _tipo;

    public Item(String _nome = "", double _valor = 0, int _tipo = 0){
        this._nome = _nome;
        this._valor = _valor;
        this._tipo = _tipo;
    }

    public String Nome{
        get {return _nome;}
    }

    public double Valor{
        get {return _valor;}
    }

    public String Tipo{
        get {
            if(_tipo == 0){
                return "Lucro";
            }
            return "Despesa";
        }
    }

}
