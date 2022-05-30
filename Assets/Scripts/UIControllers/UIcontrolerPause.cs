using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class UIcontrolerPause : MonoBehaviour
{
    VisualElement root;
    Button continueBotton, salirButton;

    // Start is called before the first frame update
    void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement.Q("Cont-PauseMenu"); 
        continueBotton = root.Q<Button>("Play");
        salirButton = root.Q<Button>("Salir");

        continueBotton.clicked += continueGame;
        salirButton.clicked += salirGame;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void continueGame()
    {
        root.style.display = DisplayStyle.None;
        Time.timeScale = 1;
    }
    void salirGame()
    {
        SceneManager.LoadScene("Nivel 1");
    }
}
