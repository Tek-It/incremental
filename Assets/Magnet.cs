using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{ 
    [SerializeField] LayerMask Magnetlayer;
    [SerializeField] float radius;

    public void Magnetizexp()
    {
        Vector2 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(origin, radius, Magnetlayer);

        foreach (Collider2D c in colliders)
        {
            if (c.GetComponent<ParticleSystem>())
        {
                Debug.Log("magnet responds");
                c.GetComponent<ParticleSystem>().Stop();

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
