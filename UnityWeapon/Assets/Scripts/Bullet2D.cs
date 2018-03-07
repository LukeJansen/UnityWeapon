using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2D : MonoBehaviour
{

    public float speed = 5.0f;
    public float decay = 0.01f;
    public float destroyTime = 1.0f;

    void Start()
    {
        Invoke("Die", destroyTime);
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        CancelInvoke("Die");
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
        if (speed > 0) speed -= decay;
        decay *= 1.01f;
    }

    public void Stop()
    {
        Debug.Log("Stop");
        speed = 0;
    }
}

