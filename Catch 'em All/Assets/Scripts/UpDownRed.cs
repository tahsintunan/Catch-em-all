﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownRed : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;
    private bool shuru = true;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (shuru == true)
        {
            targetPos = new Vector2(-9, -2);
            shuru = false;
        }

        if (Input.GetKey ("up") && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(-9, transform.position.y + Yincrement);
        }
        else if (Input.GetKey ("down") && transform.position.y > minHeight)
        {
            targetPos = new Vector2(-9, transform.position.y - Yincrement);
        }
    }
}
