using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheildPowerup : MonoBehaviour
{ private ParticleSystem ps;
    public float duration =1f;
    public GameObject ShieldAnimation;
    public GameObject temp;
    
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

        gamemanager.hasSheild=true;
        gamemanager.timeRemaining=gamemanager.sheildTimeLimit;

        Instantiate(ShieldAnimation,collision.transform.position,collision.transform.rotation);
        Destroy(this.gameObject);


    }
            if(collision.gameObject.tag == "Finish"){
                    // Debug.Log("killed");
        Destroy(this.gameObject);
        }
    }




}
