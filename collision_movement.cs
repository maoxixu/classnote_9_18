using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_movement : MonoBehaviour
{
    bool isitcolliding;
    // Start is called before the first frame update
    void Start()
    {
        isitcolliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isitcolliding == false)
        {
            transform.position += new Vector3(0, 0, 4 * Time.deltaTime);

        }
        if(isitcolliding ==true)
        {
            transform.position += new Vector3(0, 0, -4 * Time.deltaTime);
        }
        
    }
    void OncollisionEnter (Collision other)
    {
        if(other.gameObject.tag == "WallNorth")
        {
            isitcolliding= true;
            //transform.position += new Vector3(0, 0, 0);

        }
        if(other.gameObject.tag == "WallSouth" && isitcolliding == true)
        {
            isitcolliding = false;
            transform.position += new Vector3(0, 0, 0);
        }
    }
}
