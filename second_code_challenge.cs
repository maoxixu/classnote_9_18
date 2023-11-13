using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{   //declaring a float variable and call it horizontalmovement 
    float horizontalmovement; 
    //declaring a float varaible and call it vertical movement
    float verticalmovement;
    //declaring a float variable and call it speed
    float speed ;
    //declaring a float variable and call it jumpheight
    float jumpheight ;
   //set a Rigidboay and call it player
    Rigidbody player; 



    // Start is called before the first frame update
    
    void Start()
    {    //call the setvarialbe method
        setvariable(); 
        
    }

    // Update is called once per frame
    void Update()
    {  //call the MakeMeJump method
        MakeMeJump(); 
       //call the MakeMeMove method
        MakeMeMove(); 
    }
    //create a method call MakeMeMove
    void MakeMeMove() 
    {
        //set the horizontalmovement use Input.GetAxis
        //this allow user use A and D keys to move 
        horizontalmovement = Input.GetAxis("Horizontal");
        //set the verticalmovement use Input.GetAxis
        //this allow user use W and S keys to move
        verticalmovement = Input.GetAxis("Vertical");
        //make the gameobject move in x direction.
        transform.Translate(horizontalmovement * speed * Time.deltaTime, 0, 0);
        //make the gameobject move in z direction;
        transform.Translate(0, 0, verticalmovement * speed * Time.deltaTime);
    }
    //create a method call MakeMeJump
    void MakeMeJump()
    { //if using space Key  
        if(Input.GetButtonDown("Jump"))
        {//the obejct will jump
            player.AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
        }

    }
    //create a method call setvariable
    void setvariable()
    {
        speed = 5f; //set speed to 5f
        jumpheight = 5f;//set jumpheight to 5f
        player = GetComponent<Rigidbody>();//set player to GetComponent<Rigidbody>
    }
}
