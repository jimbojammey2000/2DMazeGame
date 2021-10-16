
using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    public override void Interact()
    {
        base.Interact();
        Pickup();
    }
        void Pickup()
    {
        Debug.Log("picking up"+ item.name);
        Inventory2.instance.Add(item);
        Destroy(gameObject);
    }
}
