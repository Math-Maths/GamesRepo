using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour
{

    [SerializeField]
    float speed = 7f;
    
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime, Space.Self);

        if(transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
