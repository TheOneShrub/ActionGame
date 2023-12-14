using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    private TextMeshProUGUI currentLives;
    private PlayerLives livesScript;
    public GameObject fenceGO;
    // Start is called before the first frame update
    void Start()
    {
        currentLives = GetComponent<TextMeshProUGUI>();
        livesScript = fenceGO.GetComponent<PlayerLives>();
    }

    // Update is called once per frame
    void Update()
    {
        currentLives.text = "Lives: " + livesScript.lives;
    }
}
