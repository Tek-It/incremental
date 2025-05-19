using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnPlayButton()
    {
        SceneManager.LoadScene("actual scene");
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
    public void OnUpgradesButton()
    {
        SceneManager.LoadScene("Upgrades screen");
    }
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
