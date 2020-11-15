using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{   public GameObject obsP;
    public GameObject player;
    public float firstspawntime=0f;
    public float tfirstspawntime=2f;
    public float spawnerDistance=200f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("addobsctacle",firstspawntime,tfirstspawntime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void addobsctacle(){
        Instantiate(obsP,new Vector3(Random.Range(-10, 10),1,player.transform.position.z+spawnerDistance),Quaternion.identity);
    }
}
