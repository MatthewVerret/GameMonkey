using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerScript : MonoBehaviour
{
    Vector3 offset;

    [SerializeField]
    Transform player;
    private void Start()
    {
        offset = new Vector3(0f, 10f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
