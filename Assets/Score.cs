using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text _scoreText;
    void Start()
    {
        _ = _scoreText.text == " Score" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
