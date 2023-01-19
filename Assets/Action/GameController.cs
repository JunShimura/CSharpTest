using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    CollisionAction collisionAction;
    [SerializeField]
    GameObject displayObject;
    ValueDisplay valueDisplay;

    Dictionary<string,int > counters= new Dictionary<string,int>();

    // Start is called before the first frame update
    void Start()
    {
        collisionAction= target.GetComponent<CollisionAction>();
        valueDisplay= displayObject.GetComponent<ValueDisplay>();
        collisionAction.onCllisionEnterAction = UpdateCounter;
        collisionAction.matchCount = 5;
    }

    // Update is called once per frame
    void UpdateCounter(GameObject destination)
    {
        if (counters.ContainsKey(destination.name))
        {
            counters[destination.name]++;
        }
        else
        {
            counters[destination.name] = 1;
        }
        valueDisplay.displayText = $"Hit!{destination.name},{counters[destination.name]} times ";
    }
}
