﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinObstacle : MonoBehaviour
{
    public int point = 20;
    public float speed;

    public GameObject effect;

    public GameObject CoinSound;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBlue"))
        {
            Instantiate(CoinSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponentInParent<Basic>().score += point;
            Debug.Log(other.GetComponentInParent<Basic>().score);

            Destroy(gameObject);
        }
        else if (other.CompareTag("PlayerRed"))
        {
            Instantiate(CoinSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponentInParent<Basic>().score += point;
            Debug.Log(other.GetComponentInParent<Basic>().score);

            Destroy(gameObject);
        }
        else if (other.CompareTag("GreatBar"))
        {
            Destroy(gameObject);
        }
    }
}
