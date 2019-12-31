using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedObstacle : MonoBehaviour
{
    public int damage = 1;
    public int point = 5;
    public float speed;

    public GameObject Deffect;
    public GameObject Peffect;

    private Shake shake;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBlue"))
        {
            Instantiate(Deffect, transform.position, Quaternion.identity);
            shake.CamShake();

            other.GetComponentInParent<Basic>().health -= damage;
            Debug.Log(other.GetComponentInParent<Basic>().health);

            Destroy(gameObject);
        }
        else if (other.CompareTag("PlayerRed"))
        {
            Instantiate(Peffect, transform.position, Quaternion.identity);

            other.GetComponentInParent<Basic>().score += point;
            Debug.Log(other.GetComponentInParent<Basic>().score);

            Destroy(gameObject);
        }
        else if (other.CompareTag("GreatBar"))
        {
            Instantiate(Deffect, transform.position, Quaternion.identity);
            shake.CamShake();

            other.GetComponentInParent<Basic>().health -= damage;
            Debug.Log(other.GetComponentInParent<Basic>().health);

            Destroy(gameObject);
        }
    }
}