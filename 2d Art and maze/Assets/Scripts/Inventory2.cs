using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory2 : MonoBehaviour
{
    #region Singleton
    public static Inventory2 instance;

    private void Awake()
    { if (instance != null)
           {
            Debug.LogWarning("warning more than one instance of Inventory FOUND!");
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public List<Item> items = new List<Item>();
    public void Add (Item item)
    {
        items.Add(item);

        if (onItemChangedCallback != null)
        { onItemChangedCallback.Invoke(); }
    }
    public void Remove(Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
        { onItemChangedCallback.Invoke(); }
    }
}
