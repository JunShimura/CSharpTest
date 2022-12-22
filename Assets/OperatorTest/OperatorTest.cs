using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorTest : MonoBehaviour
{
    [SerializeField]
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(target == this.transform);
        if(target!= null)
        {
            if(target.position==this.transform.position)
            {
                Debug.Log("“¯‚¶êŠ‚É‚ ‚è‚Ü‚·");
            }
            if (target.forward == this.transform.forward)
            {
                Debug.Log("³–Ê‚ª“¯‚¶•ûŒü‚ğŒü‚¢‚Ä‚¢‚Ü‚·");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
