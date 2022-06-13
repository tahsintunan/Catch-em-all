using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleItem : Item
{
    public int damage = 1;
    public int point = 5;
    public float speed;

    public GameObject damageEffect;
    public GameObject pointEffect;

    public GameObject damageSound;
    public GameObject pointSound;

    public string sameColor;


    override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(sameColor))
        {
            Instantiate(pointSound, transform.position, Quaternion.identity);
            Instantiate(pointEffect, transform.position, Quaternion.identity);
            shake.CamShake();
            other.GetComponentInParent<Basic>().score += point;
            Destroy(gameObject);
            break;
        }
        else
        {
            Instantiate(damageSound, transform.position, Quaternion.identity);
            Instantiate(damageEffect, transform.position, Quaternion.identity);
            shake.CamShake();
            other.GetComponentInParent<Basic>().health -= damage;
            Destroy(gameObject);
        }
    }
}