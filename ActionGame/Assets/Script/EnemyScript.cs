using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float health = 50f;

    private ScoreScript scoring;
    public GameObject scoreboard;

    void Start(){
        scoreboard = GameObject.Find("Score");
        scoring = scoreboard.GetComponent<ScoreScript>();
    }

    public void TakeDamage(float amount){
        health -= amount;
        if(health <=0f){
            Die();
        }
    }

    void Die(){
        Destroy(enemy);
        scoring.currentScore += 100;
    }
}
