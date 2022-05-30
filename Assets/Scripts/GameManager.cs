using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class GameManager : MonoBehaviour
{
    [SerializeField] int lives;
    [SerializeField] UIDocument GameOver;
    [SerializeField] UIDocument PauseMenu;
    [SerializeField] UIDocument MainMenu;
    [SerializeField] UIDocument GanasteMenu;
    [SerializeField] string nextLevel;
    private VisualElement rootGanasteMenu;
    private VisualElement rootGameOver;
    private VisualElement rootMainMenu;
    private VisualElement rootPauseGame;

    void Start()
    {
        rootGameOver = GameOver.rootVisualElement.Q("Cont-GameOver");
        rootPauseGame = PauseMenu.rootVisualElement.Q("Cont-PauseMenu");
        rootMainMenu = MainMenu.rootVisualElement.Q("Cont-MainMenu");
        rootGanasteMenu = GanasteMenu.rootVisualElement.Q("Cont-GanasteMenu");
        
        if(SceneManager.GetActiveScene().name == "Nivel 1")
        {
            rootMainMenu.style.display = DisplayStyle.Flex;
            Time.timeScale = 0;
        }

    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            PauseLevel();
        }

        int numberOfTaggedObjects = GameObject.FindGameObjectsWithTag("Brick").Length;
        if (numberOfTaggedObjects <= 0)
        {
            StartCoroutine(PasarNivel());
        }
    }

    public void LoseLive()
    {
        lives--;

        if(lives <= 0)
        {
            Time.timeScale = 0;
            rootGameOver.style.display = DisplayStyle.Flex;   
        }
        else
        {
            ResetLevel();
        }
    }

    public void PauseLevel()
    {
        Time.timeScale = 0;
        rootPauseGame.style.display = DisplayStyle.Flex;
    }

    public void ResetLevel()
    {
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }

    IEnumerator PasarNivel()
    {
        rootGanasteMenu.style.display = DisplayStyle.Flex;
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(5);
        Time.timeScale = 1;
        rootGanasteMenu.style.display = DisplayStyle.None;
        SceneManager.LoadScene(nextLevel);
        yield return null;
    }
}
