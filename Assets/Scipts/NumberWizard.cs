﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max, min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void onPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void onPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
  
    void NextGuess()
    {
        guess = Random.Range(min,max+1);
        guessText.text = guess.ToString();
    }
}
