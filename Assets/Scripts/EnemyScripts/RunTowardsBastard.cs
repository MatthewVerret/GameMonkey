using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTowardsBastard : MonoBehaviour
{
    Transform target; //the enemy's target
    float moveSpeed = 6f; //move speed
    float rotationSpeed = 3f; //speed of turning
    float range=25f; //Range within target will be detected
    float stop=0;
    Transform myTransform; //current transform data of this enemy
    void Awake()
    {
        target = GameObject.FindWithTag("Player").transform; //target the player
        myTransform = transform; //cache transform data for easy access/preformance
    }
    void Update()
    {    //rotate to look at the player
        var distance = Vector3.Distance(myTransform.position, target.position);
        if (distance <= range)
        {
            //look
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
            Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            //move
            if (distance > stop)
            {
                myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
            }
        }
    }
}
