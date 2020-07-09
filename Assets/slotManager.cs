using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotManager : MonoBehaviour
{
    public static List<string> newItem = new List<string>() {};
    public static int slot;
    public GameObject wood;
    public GameObject stone;
    public RectTransform wP;
    public RectTransform sP;

    private void Update()
    {
       foreach(string item in newItem)
        {
            if (item.Equals("wood"))
            {
                wood.SetActive(true);
            }

            if (item.Equals("stone"))
            {
                stone.SetActive(true);
            }
        }
    }
}
