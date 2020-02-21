using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists_PracticalExample_Database : MonoBehaviour
{
    public List<Lists_PracticalExample_Item> itemDatabase = new List<Lists_PracticalExample_Item>();

    public void AddItem(int itemID, Lists_PracticalExample_Player player)
    {

        //check and see if ID matches somthing in the DataBase
        foreach(var item in itemDatabase)
        {
            if (item.id == itemID)
            {
                Debug.Log("We have a match...!!  ADD Side.");
                player.inventory[0] = item;  //ask Gabriel about this if it does not become clear...
                return;

            }
        }
        Debug.Log("Cannot add item.  Item does not exist..!!!");


    }

    public void RemoveItem(int itemID, Lists_PracticalExample_Player player)
    {
        foreach (var item in itemDatabase)
        {
            if (item.id == itemID)
            {
                player.inventory[0] = null;

            }

        }

    }



}
