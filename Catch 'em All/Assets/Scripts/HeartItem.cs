using UnityEngine;

public class HeartItem : Item
{
    public int life = 1;
    public GameObject effect;
    public GameObject healthSound;


    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GreatBar"))
        {
            Destroy(gameObject);
        }
        else
        {
            var position = transform.position;
            Instantiate(healthSound, position, Quaternion.identity);
            Instantiate(effect, position, Quaternion.identity);
            shake.CamShake();
            if (other.GetComponentInParent<GameSession>().health < other.GetComponentInParent<GameSession>().maxHealth)
                other.GetComponentInParent<GameSession>().health += life;
            Destroy(gameObject);
        }
    }
}
