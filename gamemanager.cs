using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    public Text healthText;
    public Text sheildTimeText;
    public Text scoreText;
    public Text MaxscoreText;
    public GameObject player;
    public float Maxscore;
    public static int health =3;
    public static bool hasSheild =true;
    public  static float timeRemaining = 10f;
    public  static float sheildTimeLimit = 10f;

    public bool realoaded;
    // Start is called before the first frame update
    void Start()
    {
        Maxscore=PlayerPrefs.GetFloat("MaxScore",0);
        realoaded=true;
        health=3;
    }

    // Update is called once per frame
    void Update()
    {   
        sheildTimeText.text=timeRemaining.ToString("0");
        scoreText.text=player.transform.position.z.ToString("0");
        MaxscoreText.text=Maxscore.ToString("0");
        healthText.text = health.ToString();
        if(health<=0 && realoaded){
            player.GetComponent<player>().enabled = false;
            Invoke("Restart",2f);

        }
        if(player.transform.position.y<-5){
                   
            Restart();
        }
        if(hasSheild){
            // Invoke("removeShield",sheildTimeLimit);
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }

            else{
                hasSheild=false;
            }            
        }
        


    }
    private void Restart(){

            if(player.transform.position.z>Maxscore){
                            Maxscore=player.transform.position.z;
                    }
            PlayerPrefs.SetFloat("MaxScore", Maxscore);
            realoaded=false;
            SceneManager.LoadScene("SampleScene");

    }

}
