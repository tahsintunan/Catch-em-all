using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float yIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    private Vector2 _targetPos;
    private float _x;
    public KeyCode up;          // Red = KeyCode.UpArrow, Blue = KeyCode.W
    public KeyCode down;        // Red = KeyCode.DownArrow, Blue = KeyCode.S

    
    private void Start()
    {
        _targetPos = transform.position;
        _x = _targetPos.x;
    }
            
    private void Update()
    {
        if (Input.GetKey(up) && transform.position.y < maxHeight)
            _targetPos = new Vector2(_x, transform.position.y + yIncrement);
        else if (Input.GetKey(down) && transform.position.y > minHeight)
            _targetPos = new Vector2(_x, transform.position.y - yIncrement);

        transform.position = Vector2.MoveTowards(transform.position, _targetPos, speed * Time.deltaTime);      
    }
}
