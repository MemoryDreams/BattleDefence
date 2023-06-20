using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bullet;

    public void ShootBullet(int damage, UnityEngine.Quaternion shooterRotation)
    {
        GameObject bulletInstance = Instantiate(bullet, transform.position, shooterRotation);
        BulletScript bulletInstanceScript = bulletInstance.GetComponent<BulletScript>();
        bulletInstanceScript.damage = 1;
    }
}
