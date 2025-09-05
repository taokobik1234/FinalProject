using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private Stack<GameObject> Inventory;

    private TextMeshPro m_TextMeshPro;
    public int size = 10;

    private void Awake()
    {
        Inventory = new Stack<GameObject>();
        //Grabbing the TextMeshPro component from the ItemCountText GameObject
        m_TextMeshPro = GameObject.Find("ItemCountText").GetComponent<TextMeshPro>();
    }
    public void OnCollect(GameObject obj)
    {
        if (Inventory.Count < size)
        {
            Inventory.Push(obj);
            m_TextMeshPro.text = "Capacity: "+ Inventory.Count + "/" + size;
        }
    }

    public GameObject OnRelease()
    {
        if (Inventory.Count > 0) 
        {
            Debug.Log("Item released");
            //Updates vacuum text.
            m_TextMeshPro.text = "Capacity: " + (Inventory.Count - 1) + "/" + size;
            return Inventory.Pop();
        }
        return null;
        
    }

    public bool CheckFull()
    {
        if (Inventory.Count < size) return false;
        return true;
    }
}
