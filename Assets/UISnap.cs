using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISnap : MonoBehaviour
{
    public int slotCounter;
    private int lastSlot;
    public List<int> slots = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
    public List<int> slotTaken = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

    private void Update()
    {        
       foreach(int slot in slotTaken)
        {
            lastSlot = slot - 1;
            if(lastSlot == -1)
            {
                lastSlot = 0;
            }
        }
    }
    
}
