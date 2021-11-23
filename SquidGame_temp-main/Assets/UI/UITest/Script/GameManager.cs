using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;




public enum GameState {
    menu,
    inGame,
    gameOver,
    gameClear
}
public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI gameClearText;


    public GameState currentGameState = GameState.menu;

    
    void Awake()
    {
        instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        gameClearText.gameObject.SetActive(false);
        currentGameState = GameState.menu;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("r"))
        {
            RestartGame();
        }
    }

    public void StartGame()
    {
        SetGameState(GameState.inGame);

    }

    public void GameClear()
    {
        SetGameState(GameState.gameClear);
        gameClearText.gameObject.SetActive(true);
    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
        gameOverText.gameObject.SetActive(true);
    }

    public void BackToMenu()
    {

    }

    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        { }
        else if (newGameState == GameState.inGame)
        { }
        else if (newGameState == GameState.gameOver)
        { }
        else if (newGameState == GameState.gameClear)
        { }

        currentGameState = newGameState;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
