using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 2f; //скорость снаряда 
    
    private Transform _target;
    private Vector3 _startPoint;

    public void Initialization(float lifetime, Transform target)
    {
        _target = target;
        _startPoint = transform.position;

        
    }

    void Start()
    {
        Destroy(gameObject, 5);
    }

        void FixedUpdate()
    {
        transform.position += transform.forward * _speed * Time.fixedDeltaTime;
    }


  
    
}
