using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIHandler : MonoBehaviour
{
    public GameObject InventoryUI;

    Inventory2 inventory;
    //public Text torchesUI;
   // public int torchscore;
    //public ScriptableObject Player;
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory2.instance;
        inventory.onItemChangedCallback += UpdateUI;
    }



    void Update()
    {
        //torchscore = GameObject.Find("Player").GetComponent<InventoryHandler>().torchesRemaining ;
        // torchesUI.text = torchscore.ToString();

        if (Input.GetKeyDown(KeyCode.B) && isActiveAndEnabled)
        {
            InventoryUI.SetActive(!InventoryUI.activeSelf);


        }
       if ((Input.GetKeyDown(KeyCode.B) && !isActiveAndEnabled))
        { InventoryUI.SetActive(InventoryUI.activeSelf); }
    }
    void UpdateUI()
    {
        Debug.Log("Updating UI");
    }
}
