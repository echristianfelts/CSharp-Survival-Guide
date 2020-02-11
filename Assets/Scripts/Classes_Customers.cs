using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Class_Customers
{

    /// <summary>
    /// 
    /// Add Coustomers to a database.
    /// Create at at least 3 customers via code using a constructor and then transition
    /// it to being able to add customers through the inspector.
    /// 
    /// You'll need two classes. A CoustomerDatabase (behaviour) which 
    /// holds customer information and a Customer class which defines a customer.
    /// 
    /// </summary>
    /// 

        
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;



    public Class_Customers(string firstName, string lastName, int age, string gender,string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }
}
