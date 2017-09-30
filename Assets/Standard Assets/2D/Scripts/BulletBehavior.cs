using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float attackSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(projectile, transform.position, transform.rotation);
            bullet.AddForce(new Vector2(attackSpeed,0));
        }
    }
}