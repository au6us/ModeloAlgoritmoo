using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : Bullet
{
    private void Start()
    {
        Initialize(FlywaightPointer.NormalBullet); // Usamos el Flyweight
    }

    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageBullet);
                Destroy(gameObject);
            }
        }
    }
}
