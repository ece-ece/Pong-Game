using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int player1Score= 0;
    private int player2Score = 0;
    public bool isDead;
    public GameObject DeathScreen;
    public Text scoreText;
    // Start is called before the first frame update

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
      
        if (collision.gameObject.name=="RightWall")
        {
            player1Score += 1;
            Debug.Log(player1Score);
        }
        if (collision.gameObject.name == "LeftWall")
        {
            player2Score += 1;
            Debug.Log(player2Score);
        }
        if (player1Score==10 || player2Score==10)
        {
            isDead = true;
            DeathScreen.SetActive(true);
            if (player1Score>player2Score)
            {
                scoreText.text ="Winner Player1";
            }
            else
            {
                scoreText.text = "Winner Player2";
            }
            Time.timeScale = 0;
           
            
            

        }
    }
   
   
   
    

    private void OnGUI()
    {
        GUI.color = Color.yellow;
        GUI.skin.label.fontSize = 25;
        GUI.Label(new Rect(Screen.width/2-100, 20, 100, 40),""+player1Score);
        GUI.Label(new Rect(Screen.width / 2+100, 20, 100, 40),""+player2Score);
    }

}
