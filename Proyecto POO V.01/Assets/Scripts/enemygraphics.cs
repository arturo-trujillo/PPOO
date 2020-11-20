using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemygraphics : MonoBehaviour
{
    public AIPath aiPath ; 

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.1f)
        {
            transform.localScale = new Vector3(-4f,4f,4f);
        }else if (aiPath.desiredVelocity.x <= -0.1f){
            transform.localScale = new Vector3(4f,4f,4f);
        }
        
    }
}
