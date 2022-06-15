using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] GameObject playAgainButton;
    [SerializeField] TextMeshProUGUI buttonText;
    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] QuizManager quizManager;
    ScoreKeeper scoreKeeper;

    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void Start()
    {
        ShowFinalScore();
    }

    private void ShowFinalScore()
    {
        scoreText.text = "Congratulations! \n You Scored: " + scoreKeeper.CalculateScore() + "%";
    }
}
