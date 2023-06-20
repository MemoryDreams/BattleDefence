using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GunScript gun;
    public int damage;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            gun.ShootBullet(damage, transform.rotation);
        }
    }
}
