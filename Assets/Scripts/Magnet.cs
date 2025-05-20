using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Magnet : MonoBehaviour
{ 
    public LayerMask Magnetlayer;
    public float radius;
    public AudioClip coin;

    public void Magnetizexp()
    {
        Vector2 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(origin, radius, Magnetlayer);

        foreach (Collider2D col in colliders)
        {
            if (col.GetComponent<ParticleSystem>())
        {
                Debug.Log("magnet responds");
                AudioSource.PlayClipAtPoint(coin, transform.position);
                Destroy(col.gameObject);
                FindObjectOfType<Score>().Pointsadding();
            }
       }
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Magnetizexp();
    }
    
}
