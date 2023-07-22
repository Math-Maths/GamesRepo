using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverScreen;
    public TextMeshProUGUI secondsSurvivedUI;

    bool isGameOver = false;

    void Start()
    {
        FindObjectOfType<PlayerMovement>().OnPlayerDeath += OnGameOver;
    }

    void Update()
    {
        if(isGameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void OnGameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
        secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
    }
}
