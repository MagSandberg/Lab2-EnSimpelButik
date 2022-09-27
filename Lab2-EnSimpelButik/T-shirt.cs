namespace Lab2_EnSimpelButik;

public class T_shirt : Product
{
    private string _productName;

    public override string ProductName
    {
        get { return _productName; }
        set { _productName = "T-shirt"; }
    }

    private float _price;

    public override float Price
    {
        get { return _price; }
        set { _price = 299.90f; }
    }

    private int _quantity;

    public override int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
    //Methods

}