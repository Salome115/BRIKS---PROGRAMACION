using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour
{
    Button restartButton;
    Label msgText;

    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        restartButton = root.Q<Button>("Restart");

        restartButton.clicked += restartGame;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void restartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
