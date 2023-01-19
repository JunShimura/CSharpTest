using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class CollisionAction : MonoBehaviour
{
    [NonSerialized]
    public Action<GameObject> onCllisionEnterAction;
    public int matchCount =10;
    private int count = 0;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        count++;
        if (count % matchCount == 0)
        {
            onCllisionEnterAction(collision.gameObject);
        }
    }
}
