using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
public class go : MonoBehaviour
{
    public AStarPathfinding a;
    public Transform target;
    
    public List <Node> n = new List<Node>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     n=   a.FindPath(transform.position, target.position);
        Debug.Log(n);
    }
}
