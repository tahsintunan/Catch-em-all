using UnityEngine;

public class HeartItem : Item
{
    public int life = 1;
    public GameObject healthEffect;
    public GameObject healthSound;


    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GreatBar"))
        {
            Destroy(gameObject);
        }
        else
        {
            var session = other.GetComponentInParent<GameSession>();
            if (session.health < session.maxHealth)
            {
                session.health += life;
            }
            InitiateCollisionEffects(healthSound, healthEffect, transform.position);
        }
    }
}
