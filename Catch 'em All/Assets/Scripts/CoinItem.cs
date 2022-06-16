using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinItem : Item
{
    public int point = 20;
    public GameObject effect;
    public GameObject coinSound;


    override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GreatBar"))
        {
            Destroy(gameObject);
        }
        else
        {
            Instantiate(coinSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponentInParent<GameSession>().score += point;
            Destroy(gameObject);
        }
    }
}
