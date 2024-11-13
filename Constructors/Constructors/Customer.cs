namespace Constructors;

public class Customer
{
    // note: in realworld fields are not declared as public
    public int Id;
    public string Name;

    public List<Order> Orders;

    // declare constructor

    //parameterless constructor
    public Customer()
    {
        // always ensure to initialze a list to an empty list if no value is set yet
        // although this will only work in this constructor, the rem. will not work
        // a better solution is to use the this keyword to control the flow
        Orders = new List<Order>();
    }
    // with one parameter
    public Customer(int id) 
        : this() // using the this keyword to pass constructor execution flow (although having too many use of constructors or 'this' keyword to pass flow is not a good practice
    {
        this.Id = id;
    }

    // with two parameters
    public Customer(int id, string name)
    : this(id)
    {
        this.Id = id;
        this.Name = name;
    }

}