using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public float spawnLowRange = 3f;
    public float spawnHighRange = 4f;
    public GameObject zombiePrefab;

    private ScoreScript scoring;
    public GameObject scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawner", Random.Range(1f, 3f));
        scoreboard = GameObject.Find("Score");
        scoring = scoreboard.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scoring.currentScore>=5000 && scoring.currentScore<10000){
            spawnLowRange = 2f;
            spawnHighRange = 3f;
        }
        if(scoring.currentScore>=10000 && scoring.currentScore<15000){
            spawnLowRange = 1.5f;
            spawnHighRange = 2.5f;
        }
        if(scoring.currentScore>=15000){
            spawnLowRange = 1f;
            spawnHighRange = 2f;
        }
    }

    void Spawner()
    {
        GameObject zombie = Instantiate<GameObject>(zombiePrefab);
        Vector3 pos = zombie.transform.position;
        pos = transform.position;
        pos.x += Random.Range(-3, 3);
        zombie.transform.position = pos;
        Invoke("Spawner", Random.Range(spawnLowRange, spawnHighRange));
    }
}
