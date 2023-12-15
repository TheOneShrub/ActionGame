using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    static public int finalScore;
    private ScoreScript scoring;
    public GameObject scoreboard;
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GameObject.Find("Score");
        scoring = scoreboard.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0){
            finalScore = scoring.currentScore;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            lives--;
        }
    }
}
