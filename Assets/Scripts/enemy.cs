using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;

    public Collider2D col;

    public PhysicsMaterial2D bouncyMaterial;

    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;

    [SerializeField] private float _health;

    private Transform Enemypos;
    [SerializeField] private GameObject xp;
    public void _damaged()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        _health--;
        Debug.Log("enemy health is now" + _health);
        GetComponent<SpriteRenderer>().color = Color.white;
        if (_health <= 0)
        {
            Enemypos = GetComponent<Transform>();
            XPdrop();
            Destroy(gameObject);
            


        }
    }
    public void XPdrop()
    {
        Instantiate(xp, Enemypos.position, Quaternion.identity);
    }
    private void SetVelocity()
    {
        float xdir = Random.Range(0, 2) == 0 ? -1 : 1;
        float ydir = Random.Range(0, 2) == 0 ? -1 : 1;
        _rigidbody.velocity = new Vector2(xdir, ydir) * _speed;
    }


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        SetVelocity();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();

        if (bouncyMaterial != null)
        {
            col.sharedMaterial = bouncyMaterial;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
