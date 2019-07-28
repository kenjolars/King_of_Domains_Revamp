using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawnP2 : MonoBehaviour
{
    public GameObject[] Characters2;
    public Transform PlayerSpawnPoint2;

    void Start()
    {
        Instantiate(Characters2[CharSelect2.PlayerNum2], PlayerSpawnPoint2.position, PlayerSpawnPoint2.rotation);
    }

}
