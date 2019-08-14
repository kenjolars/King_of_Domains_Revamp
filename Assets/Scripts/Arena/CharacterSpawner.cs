using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public Transform[] playerSpawnPoints;

    /// <summary>
    /// The array of character prefabs (Elf, Man and Orc).
    /// </summary>
    public GameObject[] characterPrefabs;

    void Start()
    {
        GameObject newCharacterPlayerOne = Instantiate(characterPrefabs[(int)SpawnDataHolder.selectedCharacters[0] - 1], playerSpawnPoints[0].position, Quaternion.identity) as GameObject;
        GameObject newCharacterPlayerTwo = Instantiate(characterPrefabs[(int)SpawnDataHolder.selectedCharacters[1] - 1], playerSpawnPoints[1].position, Quaternion.identity) as GameObject;

        newCharacterPlayerOne.GetComponent<PlayerController>().playerNumber = 1;
        newCharacterPlayerTwo.GetComponent<PlayerController>().playerNumber = 2;
    }
}
