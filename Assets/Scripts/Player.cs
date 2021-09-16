using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed; // скорость 
    private Vector3 _direction; // напрвление 

    [SerializeField] public GameObject _bulletPrefab; //Снаряд
    public Transform _firePoint; //Точка, с которой будут отправляться снаряды и лучи

    void Start()
    {
  
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl)) //Если игрок нажал на правый Ctrl
        {
            
            ShootBullet(); //Вызов метода стрельбы снарядами
        }
       
    }
    private void FixedUpdate()
    {
        _direction.x = Input.GetAxis("Horizontal");

        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
        
    }
    void ShootBullet()
    {
        Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
    }
}
