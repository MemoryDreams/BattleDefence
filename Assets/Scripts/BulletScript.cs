using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 1f;
    private float counter = 5f;
    public int damage = 1;
    private float timer;

    void FixedUpdate(){
        transform.position += transform.up * speed * Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > counter) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D targetInfo){
        VitalityScript target = targetInfo.GetComponent<VitalityScript>(); 
        if (target != null) {
            target.takeDamage(damage);
        }
        Destroy(gameObject);
    }
}
