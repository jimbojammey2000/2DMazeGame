using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
  
    public Animator animator;
    //public Animator chest;

    //movment vars
    [SerializeField] private float MovementSpeed = 1;
   
    [SerializeField]private float sumOfMovement;
    private float eastWestMovement;
    private float northSouthMovement;
    private Vector3 currentEulerAngles;
    private bool toggleShimmy;

    //vars for torch dropping.
    private Transform playerDropLocation;
    public GameObject GroundTorch;
    //public int torchesRemaining;

    

    // Start is called before the first frame update
    void Start()
    {
        playerDropLocation = GetComponent<Transform>();
       
    }



    // Update is called once per frame
    void Update()
    {
        eastWestMovement = Input.GetAxis("Horizontal");
        northSouthMovement = Input.GetAxis("Vertical");
        sumOfMovement = Mathf.Abs(northSouthMovement) + Mathf.Abs(eastWestMovement);
        
        if(sumOfMovement == 0)
        {
            animator.SetBool("isWalking", false);
        }
        if (sumOfMovement != 0)
        {
            animator.SetBool("isWalking",true);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && toggleShimmy == false)
        { 
            toggleShimmy = true;
            MovementSpeed = 1;
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift)&& toggleShimmy == true){
            toggleShimmy = false;
            MovementSpeed = 1.75f;
        }


        //  if (Input.GetKey(KeyCode.Space)) Sprint. But it doesent seem to untoggle on key not being held anymore.
        //{
        //    MovementSpeed = 1.75f;
        //}
        // if (toggleShimmy)
        //{
        //    MovementSpeed = .75f;
        // }


     

    }

    private void FixedUpdate()
    {
      
        transform.position += new Vector3(eastWestMovement, 0, 0) * Time.deltaTime * MovementSpeed;
        transform.position += new Vector3(0, northSouthMovement, 0) * Time.deltaTime * MovementSpeed;

  
        
        if (Input.GetKey(KeyCode.D) ) //right movment 0
        {
            currentEulerAngles = new Vector3(0,0,270);
            if (toggleShimmy == true)
            {
                currentEulerAngles = new Vector3(0, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.A))  //Left movment 180
        {
            currentEulerAngles = new Vector3(0, 0, 90);
            if (toggleShimmy == true)
            {
                currentEulerAngles = new Vector3(0, 0, 180);
            }
        }
        if (Input.GetKey(KeyCode.S)) //DOown -90
        {
            currentEulerAngles = new Vector3(0, 0, 180);
            if (toggleShimmy == true)
            {
                currentEulerAngles = new Vector3(0, 0, 270);
            }
        }
        if (Input.GetKey(KeyCode.W)) //Up 90
        {
            currentEulerAngles = new Vector3(0, 0, 0);
            if (toggleShimmy == true)
            {
                currentEulerAngles = new Vector3(0, 0, 90);
            }
        }

       
       transform.eulerAngles = currentEulerAngles;



       // if (Input.GetKeyDown(KeyCode.R))
        {
           // if (torchesRemaining > 0)
            {
              //  Instantiate(GroundTorch, new Vector3(playerDropLocation.position.x + .5f, playerDropLocation.position.y, playerDropLocation.position.z + 1), Quaternion.identity);
               
               // torchesRemaining--;

            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)//chest torch drop
    {

         if (collision.gameObject.layer == 7 && Input.GetKeyDown(KeyCode.P))
         {
            // (Input.GetKeyDown(KeyCode.P))
           // {
                Destroy(collision.gameObject);
               // torchesRemaining++;
            
         }
        //if (collision.gameObject.layer == 6 && Input.GetKeyDown(KeyCode.E))
        {
           
              // Destroy(collision.gameObject);
              // torchesRemaining = torchesRemaining + Random.Range(3, 7);
                             //chest.SetTrigger("ChestOpened");
           
       }

        
    }
    //{
    //  if (other.gameObject.layer == 6)
    // {
    ////  onTorch = true;
    ///  if (pickupKeyPressed)
    // {
    //    Destroy(other.gameObject);
    //    torchesRemaining++;
    //    pickupKeyPressed = false;
    // }
    // }

}