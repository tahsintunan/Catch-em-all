using UnityEngine;

public class CoinItem : Item
{
    public int point = 20;
    public GameObject coinEffect;
    public GameObject coinSound;


    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GreatBar"))
        {
            Destroy(gameObject);
        }
        else
        {
            other.GetComponentInParent<GameSession>().score += point;
            InitiateCollisionEffects(coinSound, coinEffect, transform.position);
        }
    }
}
