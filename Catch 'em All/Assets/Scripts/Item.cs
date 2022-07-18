using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public float speed;
    protected Shake shake;
    
    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }

    public abstract void OnTriggerEnter2D(Collider2D other);
}
