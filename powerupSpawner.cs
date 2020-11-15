using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupSpawner : MonoBehaviour
{   public GameObject[] Sheild;
    public GameObject player;
    public float firstspawntime=1f;
    public float tfirstspawntime=15f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("powerUpSpawn",firstspawntime,tfirstspawntime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void powerUpSpawn(){
        // Debug.Log("test");
       Instantiate(Sheild[ Random.Range(0, 2)],new Vector3(Random.Range(-10, 10),1,player.transform.position.z+75),Quaternion.identity);
      
    }
}