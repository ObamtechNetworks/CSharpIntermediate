namespace Fields;

public class Customer
{
    public int Id;
    public string Name;
    // list must be initialized to an empty list
    public readonly List<Order> Orders = new List<Order>(); // some devs said this approach is better;
    // with the above, no matter the type of constructor being called, the orders field is always initialzied to an empty list

    // having a default constructor is called first
    // some developers argue with this approach saying the orders field is not dependent on any parameter
    /*public Customer()
        {
            Orders = new List<Order>(); // can be fine
        }*/
    public Customer(int id)
    {
        this.Id = id;
    }

    public Customer(int id, string name)
        : this(id)
    {
        this.Name = name;
    }

    public void Promote()
    {
        // illustrating errors that can occur when readonly fields are not used for certain case
        //  and accidental clearing out of data
        // intializing the orders field to an empty field
        // Orders = new List<Order>(); // this is prevent by adding the readonly property to the declaring of the Orders field
    }
}