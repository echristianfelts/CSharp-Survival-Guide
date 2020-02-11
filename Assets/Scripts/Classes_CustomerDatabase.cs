using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_CustomerDatabase : MonoBehaviour
{
    public Class_Customers eric;
    public Class_Customers christian;
    public Class_Customers lucy;
    public Class_Customers jacob;
    public Class_Customers richard;


    // Start is called before the first frame update
    void Start()
    {
        eric = new Class_Customers("Eric", "Felts", 049, "male", "Artist");
        christian = new Class_Customers("Christian", "Felts", 050, "male", "Unemployed");
        lucy = new Class_Customers("lucy", "Lin", 055, "female", "Student");
        jacob = new Class_Customers("Jacob", "Marley", 022, "male", "Accountant");
        richard = new Class_Customers("Richard", "Quncey", 065, "male", "Supervisor");

    }


}
