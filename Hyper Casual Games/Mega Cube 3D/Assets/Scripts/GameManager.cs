using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : SingletionMono<GameManager>
{
   

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI bestScoreText;
    [SerializeField] TouchSlider touchSlider;

    [SerializeField] Button resetButton, backToMainButton;
    public Button pauseButton;

    int score = 0;
    int bestScore = 0;

    public bool isOn = false;
    public bool isGameOver = false;

    public override void Awake()
    {        
        if (PlayerPrefs.HasKey("BestScore"))
        {
            bestScore = PlayerPrefs.GetInt("BestScore");
            bestScoreText.text = "Best: " + bestScore.ToString();
        }

        pauseButton.onClick.AddListener(() => { SwitchButton(); });
    }

    public void SetScore(int addValue)
    {
        score += addValue;
        UpdateBestScore();

        scoreText.text = "Score : " + score.ToString();
    }

    void UpdateBestScore()
    {
        if(score > bestScore && isGameOver == true)
        {
            bestScore = score;

            bestScoreText.text = "Best: " + bestScore.ToString();

            PlayerPrefs.SetInt("BestScore", bestScore);
        }
    }

   public void ClearData()
    {
        PlayerPrefs.DeleteKey("BestScore");

        bestScore = 0;
        bestScoreText.text = "Best: " + bestScore.ToString();
    }

    public void SwitchButton()
    {
        isOn = !isOn;
        if(isOn == true)
        {
            resetButton.gameObject.SetActive(true);
            backToMainButton.gameObject.SetActive(true);
            touchSlider.gameObject.SetActive(false);            
        }
        else
        {
            resetButton.gameObject.SetActive(false);
            backToMainButton.gameObject.SetActive(false);
            touchSlider.gameObject.SetActive(true);
        }
        
    }

    public void GameOverButt()
    {
        resetButton.gameObject.SetActive(true);
        backToMainButton.gameObject.SetActive(true);
        touchSlider.gameObject.SetActive(false);
    }

}
