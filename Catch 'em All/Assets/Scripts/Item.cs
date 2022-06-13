using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Item : MonoBehaviour
{
    public float speed;
    private Shake shake;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public abstract void OnTriggerEnter2D(Collider2D other);
}
