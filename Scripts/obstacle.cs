using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        //  this.ParticleSystem.Emit = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player"){

        Destroy(this.gameObject);
        if(!gamemanager.hasSheild){

        gamemanager.health-=1;
        }
        }
        if(collision.gameObject.tag == "Finish"){
                    // Debug.Log("killed");
        Destroy(this.gameObject);
        }
    }

}
