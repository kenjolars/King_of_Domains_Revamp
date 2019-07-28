using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawn : MonoBehaviour
{
    public GameObject[] Characters;
    public Transform PlayerSpawnPoint;

    void Start()
    {
        Instantiate(Characters[CharSelect.PlayerNum], PlayerSpawnPoint.position, PlayerSpawnPoint.rotation);
    }

}
