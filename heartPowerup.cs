using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartPowerup : MonoBehaviour
{
    public GameObject heartAnimation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
      
        if(collision.gameObject.tag == "Player"){
            // Debug.Log("sheild");
            gamemanager.health+=1;
        Instantiate(heartAnimation,collision.transform.position,collision.transform.rotation);
        Destroy(this.gameObject);

    }
    if(collision.gameObject.tag == "Finish"){
                    // Debug.Log("killed");
        Destroy(this.gameObject);
        }
    }

}
