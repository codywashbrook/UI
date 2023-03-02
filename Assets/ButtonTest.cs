using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonTest : MonoBehaviour
{
    private Text score;
    private int scoreAmount;
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        score.text = scoreAmount.ToString();
    }

    public void PressPlay()
    {
        Debug.Log("Play");
    }

    public void AddScore()
    {
        scoreAmount += 5;
    }

    public void LessScore()
    {
        scoreAmount -= 5;
    }
}
