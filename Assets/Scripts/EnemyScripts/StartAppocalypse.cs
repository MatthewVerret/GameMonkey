using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAppocalypse : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy;

    [SerializeField]
    private float time;
    private float elapsedTime;

    private bool gotHit = false;

    public int nbEnemy;

    [SerializeField]
    GameObject House;
    SpawnEnemy spawn;

    private void Start()
    {
        spawn = GetComponent<SpawnEnemy>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            gotHit = true;
        }
    }
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (gotHit && elapsedTime > time && nbEnemy > 0)
        {
            spawn.Spawn(Enemy, 1, House);
            nbEnemy--;
            elapsedTime = 0;
        }
    }
}
