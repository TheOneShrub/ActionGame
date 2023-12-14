using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private TextMeshProUGUI score;
    public int currentScore;

    public GameObject gameObj;
    // Start is called before the first frame update
    void Start(){
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + currentScore;
    }
}
