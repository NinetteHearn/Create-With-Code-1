using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSelection : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    [SerializeField] private int gameSelection;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(GameTypeSelection);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GameTypeSelection()
    {
        gameManager.StartGame(gameSelection);
    }
}
