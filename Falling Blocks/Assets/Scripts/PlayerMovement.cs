using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 7f;

    float halfCameraWidthScreenSize;

    void Start()
    {
        float playerHalfWidth = transform.localScale.x / 2f;
        halfCameraWidthScreenSize = Camera.main.aspect * Camera.main.orthographicSize + playerHalfWidth;
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float velocity = inputX * speed;
        transform.Translate(Vector2.right * velocity * Time.deltaTime);

        if(transform.position.x < -halfCameraWidthScreenSize)
        {
            transform.position = new Vector2(halfCameraWidthScreenSize, transform.position.y);
        }

        if(transform.position.x > halfCameraWidthScreenSize)
        {
            transform.position = new Vector2(-halfCameraWidthScreenSize, transform.position.y);
        }
    }
}
