using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Rigidbody2D _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        SetVelocity();
    }

    private void FixedUpdate()
    {
        
    }

    private void SetVelocity()
    {
        float xdir = Random.Range(0, 2) == 0 ? -1 : 1;
        float ydir = Random.Range(0, 2) == 0 ? -1 : 1;
        _rigidbody.velocity = new Vector2(xdir, ydir) * _speed;
    }
}
