using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour
{
    public Vector2 speedMinMax;

    [SerializeField]
    float speed;
    
    void Start()
    {
        speed = Mathf.Lerp(speedMinMax.y, speedMinMax.x, Difficult.GetSecondsToMaxDifficult());
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime, Space.Self);

        if(transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
