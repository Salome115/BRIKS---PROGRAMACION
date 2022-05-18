using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    [SerializeField] int lives;
    [SerializeField] UIDocument GameOver;
    private VisualElement root;

    void Start()
    {
        root = GameOver.rootVisualElement.Q("Cont-GameOver");
    }
    public void LoseLive()
    {
        lives--;

        if(lives <= 0)
        {
            Time.timeScale = 0;
            root.style.display = DisplayStyle.Flex;   
        }
        else
        {
            ResetLevel();
        }
    }

    public void ResetLevel()
    {
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }
}
