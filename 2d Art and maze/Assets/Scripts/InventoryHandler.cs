using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHandler : MonoBehaviour
{

    private bool chestLooted;
    public int torchesRemaining;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
  
  
    public void OpenChest()
    {
       // chestLooted = GameObject.Find("Chest").GetComponent<ChestLoot>().isLooted;
        if (!chestLooted)
        {
            //torchesRemaining = GameObject.Find("Chest").GetComponent<ChestLoot>().torchesInChest +torchesRemaining;
            Debug.Log("rewards!");
            chestLooted = true;
            torchesRemaining = torchesRemaining + Random.Range(3, 6);
        }
        else
        {
            Debug.Log("you already got it");
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
