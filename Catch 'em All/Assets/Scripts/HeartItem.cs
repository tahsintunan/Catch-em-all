using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartItem : Item
{
    public int life = 1;
    public GameObject effect;
    public GameObject healthSound;


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
            if (other.GetComponentInParent<GameSession>().health < other.GetComponentInParent<GameSession>().maxHealth)
                other.GetComponentInParent<GameSession>().health += life;
            Destroy(gameObject);
        }
    }
}
