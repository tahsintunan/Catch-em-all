using UnityEngine;

public class ObstacleItem : Item
{
    public int damage = 1;
    public int point = 5;
    public GameObject damageEffect;
    public GameObject pointEffect;
    public GameObject damageSound;
    public GameObject pointSound;
    public string color;    // "PlayerBlue" or "PlayerRed"
    
    
    public override void OnTriggerEnter2D(Collider2D other)
    {
        var position = transform.position;
        
        // If the player gets hit by a same color obstacle, the player will get points.
        if (other.CompareTag(color))
        {
            Instantiate(pointSound, position, Quaternion.identity);
            Instantiate(pointEffect, position, Quaternion.identity);
            shake.CamShake();
            other.GetComponentInParent<GameSession>().score += point;
            Destroy(gameObject);
        }
        // If the player gets hit by a different color obstacle, the player will get damage.
        else
        {
            Instantiate(damageSound, position, Quaternion.identity);
            Instantiate(damageEffect, position, Quaternion.identity);
            shake.CamShake();
            other.GetComponentInParent<GameSession>().health -= damage;
            Destroy(gameObject);
        }
    }
}