using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject gameOverMenu;
    

    private bool playerActive = false;
    private bool gameOver = false;
    private bool gameStarted = false;
    private bool gameReset = false;

    public bool GameReset
    { get { return gameReset; } }

    public bool GameStarted
    {
        get { return gameStarted; }
    }

    public bool PlayerActive
    {
        get { return playerActive; }
    }

    public bool GameOver
    {
        get { return gameOver; }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        Assert.IsNotNull(mainMenu);
        Assert.IsNotNull(gameOverMenu);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerCollided()
    {
        gameOverMenu.SetActive(true);
        gameOver = true;
    }

    public void PlayerStartedGame()
    {
        playerActive = true;
        gameReset = false;
    }

    public void EnterGame()
    {
        mainMenu.SetActive(false);
        gameStarted = true;
    }

    public void Restart()
    {
        gameReset = true;
        gameOver = false;
        playerActive = false;
        gameOverMenu.SetActive(false);

    }
}
