using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }
    public string GetName()
    {
        return _customerName;
    }

    public bool ItIsFromUSA()
    {
        if (_customerAddress.FromUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustumerAddress()
    {
        return _customerAddress.GetAddress();
    }
    }
