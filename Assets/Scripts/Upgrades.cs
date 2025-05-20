using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public int dmglvl;
    public Text damagecost;
    public Text enemycost;
    public Text enemycost2;


    public void OnGoBackButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnPlayerDmgButton()
    {
        int dmgcost = (50 * (1 + dmglvl));
        
        if (PlayerPrefs.GetInt("Score") >= dmgcost ) 
        {
            
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - dmgcost);
            float Playerdmg = PlayerPrefs.GetFloat("PlayerDmg", 1);
            Playerdmg = (float)(Playerdmg * 1.20);
            PlayerPrefs.SetFloat("PlayerDmg",Playerdmg);
            dmglvl++;
            PlayerPrefs.SetInt("PlayerDmgLvL", dmglvl);
        }
        

    }
    public void OnNewEnemyButton()
    {
        if ((PlayerPrefs.GetInt("Score") >= 20) && ((PlayerPrefs.GetInt("Triangles", 0) == 0)))
        {
            PlayerPrefs.SetInt("Triangles",1);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 20);
        }

    }
    public void OnNewerEnemyButton()
    {
        if ((PlayerPrefs.GetInt("Score") >= 50) && ((PlayerPrefs.GetInt("Hexagons", 0) == 0)))
        {
            PlayerPrefs.SetInt("Hexagons", 1);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 50);
        }

    }






    // Start is called before the first frame update
    void Start()
    {
        dmglvl = PlayerPrefs.GetInt("PlayerDmgLvL",0);
    }

    // Update is called once per frame
    void Update()
    {
        damagecost.text = "cost : " + 50 * (1+dmglvl);
        enemycost.text = "cost : " + 20;
        enemycost2.text = "cost : " + 50;
    }
}
