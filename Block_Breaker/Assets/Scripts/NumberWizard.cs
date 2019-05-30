using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    public int maxGuessesAllowed = 5;
    public Text text;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
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

    void NextGuess()
    {
        guess = (Random.Range(min, max + 1));
        if (text != null)
            text.text = guess.ToString();
        maxGuessesAllowed -= 1;
        if (maxGuessesAllowed <= 0)
        {
            EditorSceneManager.LoadScene("Lose");

        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GuessHigher();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GuessLower();
        }
    }
}