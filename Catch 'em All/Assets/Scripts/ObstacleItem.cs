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
        var session = other.GetComponentInParent<GameSession>();
        
        if (other.CompareTag(color))
        {
            session.score += point;
            InitiateCollisionEffects(pointSound, pointEffect, position);
        }
        else
        {
            session.health -= damage;
            InitiateCollisionEffects(damageSound, damageEffect, position);
        }
    }
}
