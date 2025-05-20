using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AoEscript : MonoBehaviour

{
     public LayerMask AoE;
     public float radius;
    public AudioClip click;
    public float volume = 3;

    public void AreaOfEffectDamage()
    {
        Vector2 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(origin, radius, AoE);

        foreach(Collider2D col in colliders)
        {
            if (col.GetComponent<Enemy>())
            {
                col.GetComponent<Enemy>().Damaged();
                
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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            AreaOfEffectDamage();
            AudioSource.PlayClipAtPoint(click, origin, volume);
            Debug.Log("you pressed m1");
        }
    }
}
    