using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    private TextMeshProUGUI finalScore;
    // Start is called before the first frame update
    void Start()
    {
        finalScore = GetComponent<TextMeshProUGUI>();
        finalScore.text = "Score: " + PlayerLives.finalScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
