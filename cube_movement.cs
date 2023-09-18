using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_movement : MonoBehaviour
{
    float speed;
    float leftside;
    float rightside;
    float upside;
    float downside;
    float forward;
    float backward;

    float jumpheight = 5f;
    float horiMovement;
    float vertMovement;
    Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.0f;
        player = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horiMovement = Input.GetAxis("Horizontal");
        transform.Translate(horiMovement * speed * Time.deltaTime, 0, 0);
       
        vertMovement = Input.GetAxis("Vertical");
        transform.Translate(0, 0, vertMovement * speed * Time.deltaTime);
        transform.rotation = Quaternion.identity;



        if (Input.GetButtonDown("Jump"))
        {
            player.AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
        }

        
    }
}
