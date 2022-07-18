using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool multiPlayer = false;

    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera secondCamera;
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private TextMeshProUGUI playerOne;
    [SerializeField] private TextMeshProUGUI playerTwo;
    [SerializeField] private TextMeshProUGUI gameOverText;

    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(int gameSellection)
    {
        if (gameSellection == 2)
        {
            multiPlayer = true;
            playerOne.gameObject.SetActive(true);
            playerTwo.gameObject.SetActive(true);
            mainCamera.rect = new Rect(0f, 0f, 0.5f, 1f);
            secondCamera.gameObject.SetActive(true);
        }
        else
        {
            multiPlayer = false;
            playerOne.gameObject.SetActive(true);
            mainCamera.rect = new Rect(0f, 0f, 1f, 1f);
            secondCamera.gameObject.SetActive(false);

        }


        titleScreen.gameObject.SetActive(false);
        isGameActive = true;
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
