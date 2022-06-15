using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] QuizManager quizManager;
    [SerializeField] EndScreen endScreen;

    private void Awake()
    {
        quizManager = FindObjectOfType<QuizManager>();
    }

    private void Start()
    {
        quizManager.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    private void Update()
    {
        ActivateEndScreen();
    }

    private void ActivateEndScreen()
    {
        if (quizManager.IsComplete == true)
        {
            quizManager.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
        }
    }

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
