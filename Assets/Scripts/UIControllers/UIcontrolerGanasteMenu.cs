using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class UIcontrolerGanasteMenu : MonoBehaviour
{
    VisualElement root;
    Button playBotton;

    // Start is called before the first frame update
    void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement.Q("Cont-MainMenu"); 
        playBotton = root.Q<Button>("Play");    

        playBotton.clicked += StartGame;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        root.style.display = DisplayStyle.None;
        Time.timeScale = 1;
    }
}
