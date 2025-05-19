using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public int dmglvl;
    public Text damagecost;
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
            PlayerPrefs.SetFloat("PlayerDmgLvL", dmglvl);
        }
        

    }






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        damagecost.text = "cost : " + 50 * (1+dmglvl);
    }
}
