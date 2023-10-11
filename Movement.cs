using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //create variable 
    float movementspeed;
    float horizontalmovemnet;
    float verticalmovemnet;

    //float jumpheight;
    Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        movementspeed = 5.5f;  //set speed;
       // jumpheight = 10f;
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalmovemnet = Input.GetAxis("Horizontal");          //set input use getAxis
        verticalmovemnet = Input.GetAxis("Vertical");
        transform.Translate(horizontalmovemnet* movementspeed * Time.deltaTime,0,0);
        transform.Translate(0,0,verticalmovemnet* movementspeed * Time.deltaTime);

       /* if (Input.GetButtonDown("Jump"))
        {
            player.AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
        }*/
        
    }
}
