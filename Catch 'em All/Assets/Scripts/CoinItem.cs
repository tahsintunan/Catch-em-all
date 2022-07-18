using UnityEngine;

public class CoinItem : Item
{
    public int point = 20;
    public GameObject effect;
    public GameObject coinSound;


    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GreatBar"))
        {
            Destroy(gameObject);
        }
        else
        {
            var position = transform.position;
            Instantiate(coinSound, position, Quaternion.identity);
            Instantiate(effect, position, Quaternion.identity);
            shake.CamShake();
            other.GetComponentInParent<GameSession>().score += point;
            Destroy(gameObject);
        }
    }
}
