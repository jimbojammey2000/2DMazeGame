using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLoot : Interactable
{
    // public bool isLooted;
    public bool isOpen;
    public Animator animator;

    public int torchesInChest;


    public override void Interact()
    {
       // base.Interact();
        OpenChest();
       
    }

      
    public void OpenChest()
   {
       if (!isOpen)
       {   
          isOpen = true;
            
           animator.SetBool("isOpen", isOpen);

           
            
           
            Debug.Log("Looted");
       }
   }


 
    }