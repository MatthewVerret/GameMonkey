using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    bool IsInHouse;

    float radius = 10f;
    //public static void Spawn(GameObject enemy, int nbEnemy)
    //{
    //    for (int cpt = 0; cpt < nbEnemy; cpt++)
    //    {
    //        float posX = Random.Range(-5, 5);
    //        float posZ = Random.Range(-5, 5);
    //        Instantiate(enemy, new Vector3(posX, 1, posZ), Quaternion.identity);
    //    }
    //}
    public void Spawn(GameObject enemy, int nbEnemy, GameObject House)
    {
        for (int cpt = 0; cpt < nbEnemy; cpt++)
        {
            float posX = Random.Range(-25, 25);
            float posZ = Random.Range(-25, 25);
            Vector3 positionEnemy = new Vector3(posX, 0, posZ);
            IsInHouse = Vector3.Distance(House.transform.position, positionEnemy) < radius;
            if (!IsInHouse)
                Instantiate(enemy, positionEnemy, Quaternion.identity);
        }
    }
}
