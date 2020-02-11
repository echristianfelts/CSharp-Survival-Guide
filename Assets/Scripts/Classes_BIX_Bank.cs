using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Classes_BIX_Bank
{ 
    public string branchName;
    public string location;
    public int moneyIntheVault;

    public void ChceckBalance()
    {
        Debug.Log("Checking Ballance: " + branchName);

    }

    public void Withdrawl()
    {
        Debug.Log("Withdrawing Money from: " + branchName);
    }

    public void Deposit()
    {
        Debug.Log("Depositing money to: " + branchName);
    }


}
