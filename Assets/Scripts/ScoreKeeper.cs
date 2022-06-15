using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int correctAnswers = 0;
    [SerializeField] int questionsSeen = 0;

    public int GetCorrectAnswer()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswer()
    {
        correctAnswers++;
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);

    }
}
