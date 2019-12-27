using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueObstacle : MonoBehaviour
{
    public int damage = 1;
    public int point = 5;
    public float speed;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerRed"))
        {
            other.GetComponentInParent<Basic>().health -= damage;
            Debug.Log(other.GetComponentInParent<Basic>().health);

            Destroy(gameObject);
        }
        else if (other.CompareTag("PlayerBlue"))
        {
            other.GetComponentInParent<Basic>().score += point;
            Debug.Log(other.GetComponentInParent<Basic>().score);

            Destroy(gameObject);
        }
        else if (other.CompareTag("GreatBar"))
        {
            other.GetComponentInParent<Basic>().health -= damage;
            Debug.Log(other.GetComponentInParent<Basic>().health);

            Destroy(gameObject);
        }
    }
}