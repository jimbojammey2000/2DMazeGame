using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    [SerializeField] private bool isInRange;
    [SerializeField] KeyCode interactKey;
    //[SerializeField] UnityEvent interactAction; is just a second way to call methods in scripts as interaction.
   bool hasInteracted = false; //maybe maybe this public so on signs and dialouge we can override to allow multiple interactions /rereading it

    public virtual void Interact()  //meant to be ovverridden overide in a interacble child scritp (Item pickup, Chest loot, ect.) to say what happens on the interaction.

    {
        Debug.Log("interacting with a thing");
    }

 
    // Update is called once per frame
    void Update()
    {
        if (isInRange && !hasInteracted)
        {
            if (Input.GetKeyDown(interactKey))
            {
                //interactAction.Invoke();
                Interact();
                hasInteracted = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("You have arrived!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
           Debug.Log("you have left");
        }
    }


}
