using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour 
{
    public float timeLeft = 120f;
    public Text timerTextSize;
    public Text uiScore;
    public GameObject gameOverScreen;
    public PlayerController playerController;
    public GameObject Chi1;
    public GameObject Chi2;
    public GameObject Chi3;
    public Slider health;

	// Use this for initialization
	void Start () 
    {
        //health.value = 100;
	}
	
	// Update is called once per frame
    void Update()
    {
        //ui score(unfinished)
        uiScore.text = ("Current Score: ");
        //sets timeleft to the hud
        timerTextSize.text = "Time left: " + timeLeft;

        //sets the players health to the health.value slider
        //playerController.playersHealth = health.value;

        //time left if time less than 0 start gameover
        timeLeft -= Time.deltaTime;

        PlayerChi();

        if (timeLeft < 0)
        {
            GameOver();

        }
    }
    void PlayerChi()
    {
        if (playerController.chi == 1)
        {
            Chi1.SetActive(true);
            Chi2.SetActive(false);
            Chi3.SetActive(false);
        }
        if (playerController.chi == 2)
        {
            Chi1.SetActive(true);
            Chi2.SetActive(true);
            Chi3.SetActive(false);
        }
        if (playerController.chi == 3)
        {
            Chi1.SetActive(true);
            Chi2.SetActive(true);
            Chi3.SetActive(true);
        }
    }
    //game over screen (unfinished)
    void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }
    //reset function (unfinished)
    public void restart()
    {
        //Application.LoadLevel (Scenes.Title);
        gameOverScreen.SetActive(false);

    }
}
