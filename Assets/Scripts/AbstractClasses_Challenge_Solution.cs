using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractClasses_Challenge_Solution : MonoBehaviour
{
    public static string company = "GameDevHQ";
    public string employeeName;

    public abstract void CalculateMonthlySalary();

}

public class PartTime : AbstractClasses_Challenge_Solution
{
    public int hoursWorked;
    public int hourlyRate;

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}

public class FullTime : AbstractClasses_Challenge_Solution
{
    public int salary;
    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }

}
