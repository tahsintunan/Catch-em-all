using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public Vector2 targetPos;
    public Vector2 startPos;    // Red = Vector2(-9, -2), Blue = Vector2(-9, 4)
    public float yIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public KeyCode up;          // Red = KeyCode.UpArrow, Blue = KeyCode.W
    public KeyCode down;        // Red = KeyCode.DownArrow, Blue = KeyCode.S

    
    private void Start()
    {
        transform.position = startPos;
    }
            
    private void Update()
    {
        if (Input.GetKey(up) && transform.position.y < maxHeight)
            targetPos = new Vector2(-9, transform.position.y + yIncrement);
        else if (Input.GetKey(down) && transform.position.y > minHeight)
            targetPos = new Vector2(-9, transform.position.y - yIncrement);

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);      
    }
}
