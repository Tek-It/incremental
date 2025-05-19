using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;
    public int Scorevalue;
    public int TotalScore;
    void Start()
    {
        Scorevalue = PlayerPrefs.GetInt("Score");
        ScoreText.text = " Score = " + Scorevalue;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pointsadding()
    {
        Debug.Log("added 1 to score");
        Scorevalue = Scorevalue + 1;
        updatescore();
    }

    void updatescore()
    {
        ScoreText.text = " Score = " + Scorevalue.ToString();
        PlayerPrefs.SetInt("Score", Scorevalue);
    }
}
