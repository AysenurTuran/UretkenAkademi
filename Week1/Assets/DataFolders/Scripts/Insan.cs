using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insan
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

