using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AoEscript : MonoBehaviour

{
    [SerializeField] LayerMask AoE;
    [SerializeField] float radius;

    public void AreaOfEffectDamage()
    {
        Vector2 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(origin, radius, AoE);

        foreach(Collider2D col in colliders)
        {
            if (col.GetComponent<Enemy>())
            {
                col.GetComponent<Enemy>()._damaged();
                
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
            AreaOfEffectDamage();
            Debug.Log("you pressed m1");
        }
    }
}
    