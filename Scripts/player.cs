using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed=3f;
    public bool left=true;
    public bool directionChange=true;
    void Start()
    {
            InvokeRepeating("IncreaseSpeed",1f,6f);
    }


    void Update(){

        if(left){

            transform.position += new Vector3(-(speed*0.7f) * Time.deltaTime, 0,speed* Time.deltaTime);
        }
        else{

            transform.position += new Vector3((speed*0.7f) * Time.deltaTime, 0, speed* Time.deltaTime);
        }   
        if(Input.touchCount>0 && directionChange){
            changeDirection();
            directionChange=false;
            Invoke("allowChange",0.2f);
        }
        if (Input.GetKey("up"))
        {
        changeDirection();
        directionChange=false;
        Invoke("allowChange",0.5f);
            
        }
        //    Debug.Log(speed);


    }


    public void changeDirection(){
            if(left)
                {
                    left=false;
                }
            else
                {
                    left=true;

                }

    }

    public void allowChange(){
        directionChange=true;

    }
    private void IncreaseSpeed(){
        speed+=1;
    }
}
