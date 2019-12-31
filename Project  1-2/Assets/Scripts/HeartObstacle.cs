using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartObstacle : MonoBehaviour
{
    public int life = 1;
    public float speed;

    public GameObject Deffect;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerRed"))
        {
            Instantiate(Deffect, transform.position, Quaternion.identity);
            if (other.GetComponentInParent<Basic>().health <5)
                other.GetComponentInParent<Basic>().health += life;
            Debug.Log(other.GetComponentInParent<Basic>().health);

            Destroy(gameObject);
        }
        else if (other.CompareTag("PlayerBlue"))
        {
            Instantiate(Deffect, transform.position, Quaternion.identity);
            if (other.GetComponentInParent<Basic>().health < 5)
                other.GetComponentInParent<Basic>().health += life;
            Debug.Log(other.GetComponentInParent<Basic>().score);

            Destroy(gameObject);
        }
        else if (other.CompareTag("GreatBar"))
        {
            Destroy(gameObject);
        }
    }
}
