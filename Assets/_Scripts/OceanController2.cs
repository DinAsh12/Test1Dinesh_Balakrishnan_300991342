using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController2 : MonoBehaviour
{
    [Header("Dinesh, Balakrishnan 300991342, Last edited 2019/10/09")]
    public float horizSpeed = 0.1f;
    public float resetPosition = 4.8f;
    public float resetPoint = -4.8f;

    // Start is called before the first frame update
    void Start()
    {
        //Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    /// <summary>
    /// This method moves the ocean right the screen by horizSpeed
    /// </summary>
    void Move()
    {
        Vector2 newPosition = new Vector2(horizSpeed, 0.0f);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

    /// <summary>
    /// This method resets the ocean to the resetPosition
    /// </summary>
    void Reset()
    {
        transform.position = new Vector2(resetPosition, 0.0f);
    }

    /// <summary>
    /// This method checks if the ocean reaches the lower boundary
    /// and then it Resets it
    /// </summary>
    void CheckBounds()
    {
        if (transform.position.x <= resetPoint)
        {
            Reset();
        }
    }
}
