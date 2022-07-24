using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public float speed;
    private Shake _shake;
    
    private void Start()
    {
        _shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }
    
    protected void InitiateCollisionEffects(GameObject sound, GameObject effect, Vector3 position)
    {
        Instantiate(sound, position, Quaternion.identity);
        Instantiate(effect, position, Quaternion.identity);
        _shake.CamShake();
        Destroy(gameObject);
    }
    
    public abstract void OnTriggerEnter2D(Collider2D other);
}
