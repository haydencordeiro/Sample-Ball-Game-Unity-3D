using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ground;
    public GameObject player;
    public float groundz=500;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.z>groundz){
        spawnGround();

        }
    }
    void spawnGround(){
        // Instantiate(ground,new Vector3(0,0,player.transform.position.z),Quaternion.identity);
        ground.transform.position+=new Vector3(0,0,500);
        groundz+=600;
        
    }
}
