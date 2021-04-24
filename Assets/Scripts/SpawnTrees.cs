using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    [SerializeField]
    GameObject Arbre;

    [SerializeField]
    int nbArbres;

    [SerializeField]
    GameObject House;

    private int radius = 10;

    bool IsInHouse;
    void Start()
    {
        Spawn(Arbre,nbArbres);
    }
    void Spawn(GameObject arbre, int nbArbres)
    {
        for (int cpt = 0; cpt < nbArbres; cpt++)
        {
            float posX = Random.Range(-25, 25);
            float posZ = Random.Range(-25, 25);
            Vector3 positionArbre = new Vector3(posX, 0, posZ);
            IsInHouse = Vector3.Distance(House.transform.position, positionArbre) < radius; 
            if(!IsInHouse)
                Instantiate(arbre, positionArbre, Quaternion.identity);
        }
    }
}
