using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit2D : MonoBehaviour {

    public int damage = 1;
    public string ignoreTag = "";

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag(ignoreTag))
        {
            Debug.Log("Hit");
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other.collider);
        }
        else
        {
            SendMessage("Stop");
        }
    }
}
