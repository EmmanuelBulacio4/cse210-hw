using System;

public class Customer
{
    private string _custumerName;
    private Address _custumerAddress;

    public Customer(string name, Address address)
    {
        _custumerName = name;
        _custumerAddress = address;
    }
    public string GetName()
    {
        return _custumerName;
    }

    public bool ItIsFromUSA()
    {
        if (_custumerAddress.FromUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Address GetCustumerAddress()
    {
        return _custumerAddress;
    }
    }
