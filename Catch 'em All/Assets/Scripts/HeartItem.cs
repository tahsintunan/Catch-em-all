using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartItem : Item
{
    public int life = 1;
    public GameObject effect;
    public GameObject healthSound;
    public float speed;


    override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GreatBar"))
        {
            Destroy(gameObject);
        }
        else
        {
            Instantiate(healthSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            if (other.GetComponentInParent<Basic>().health <5)
                other.GetComponentInParent<Basic>().health += life;
            Destroy(gameObject);
        }
    }
}
