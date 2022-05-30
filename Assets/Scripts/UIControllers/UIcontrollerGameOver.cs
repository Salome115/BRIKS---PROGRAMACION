using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIcontrollerGameOver : MonoBehaviour
{
    private Button restartButton, salirButton;
    
    // Start is called before the first frame update
    void Start()
    {

        VisualElement root = GetComponent<UIDocument>().rootVisualElement.Q("Cont-GameOver");
        restartButton = root.Q<Button>("Restart");
        salirButton = root.Q<Button>("Exit");

        restartButton.clicked += restartGame;
        salirButton.clicked += salirGame;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    void salirGame()
    {
        SceneManager.LoadScene("Nivel 1");
    }
}
