using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int scoreAmount;
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreAmount.ToString();
    }

    public void AddScore()
    {
        scoreAmount += 5;
    }

    public void LessScore()
    {
        scoreAmount -= 5;
        if (scoreAmount < 0)
        {
            scoreAmount = 0;
        }
    }
}
