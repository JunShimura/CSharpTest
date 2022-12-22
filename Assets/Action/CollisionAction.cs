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
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        onCllisionEnterAction(collision.gameObject);
    }
}
