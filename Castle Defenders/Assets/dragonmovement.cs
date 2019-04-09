using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonmovement : MonoBehaviour
{
    public Transform endNode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(endNode.position.x, transform.position.y, endNode.position.z);
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 10f);
    }
}
