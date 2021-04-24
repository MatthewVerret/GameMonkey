using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargets : MonoBehaviour
{
    float maxValue = 2; 
    float minValue = -2; 
    float currentValue = 0; 
    float direction = 1;

    [SerializeField]
    Transform FirstPosition;

    void Update()
    {
        currentValue += Time.deltaTime * direction;
        if (currentValue >= maxValue)
        {
            direction *= -1;
            currentValue = maxValue;
        }
        else if (currentValue <= minValue)
        {
            direction *= -1;
            currentValue = minValue;
        }
        transform.position = new Vector3(FirstPosition.position.x, FirstPosition.position.y, currentValue);
    }
}
