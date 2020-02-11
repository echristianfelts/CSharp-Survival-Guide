using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Classes_BIX_Bank
{ 
    protected string branchName;
    protected string location;
    protected int moneyIntheVault;

    protected void ChceckBalance()
    {
        Debug.Log("Checking Ballance: " + branchName);

    }

    protected void Withdrawl()
    {
        Debug.Log("Withdrawing Money from: " + branchName);
    }

    protected void Deposit()
    {
        Debug.Log("Depositing money to: " + branchName);
    }


}
