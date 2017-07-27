using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Borders and guessing
    int max;
    int min;
    int guess;

    public int maxGuessesAllowed = 5;

    // Text box
    public Text text;

    // Use this for initialization
    void Start () {
        StartGame();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow pressed");
            GuessHigher();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down arrow pressed");
            GuessLower();
        }
    }

    void StartGame() {
        // Borders and guessing
        max = 1000;
        min = 1;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess() {
        // Guessing
        guess = Random.Range(min, max+1);
        // Changing the guess on the UI
        text.text = "Is your number " + guess.ToString() + "?";
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

}
