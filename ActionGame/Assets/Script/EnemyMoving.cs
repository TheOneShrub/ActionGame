using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    public GameObject zombie;
    private ScoreScript scoring;
    public GameObject scoreboard;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GameObject.Find("Score");
        scoring = scoreboard.GetComponent<ScoreScript>();
        if(scoring.currentScore >= 5000 && scoring.currentScore < 10000){
            speed = Random.Range(2f, 3f);
        }
        if(scoring.currentScore >= 10000 && scoring.currentScore < 15000){
            speed = Random.Range(2f, 5f);
        }
        if(scoring.currentScore >= 15000){
            speed = Random.Range(3f, 6f);
        }
    }

    // Update is called once per frame
    void Update(){
        zombie.transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
        if (collision.gameObject.tag == "Boundary")
        {
            Debug.Log("Working");
            speed = 0f;
        }
    }
}
