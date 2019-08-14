using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDataHolder : MonoBehaviour
{
    public enum CharacterClass { Unassigned, Elf, Man, Orc }

    /// <summary>
    /// The character each player has selected.
    /// 0 = Player 1
    /// 1 = Player 2
    /// </summary>
    public static CharacterClass[] selectedCharacters = new CharacterClass[2];

    public void SelectCharacterP1(int selectedCharacter)
    {
        //PlayerNum = SelectedNum;
        //Application.LoadLevel("3 Char Select2");
        selectedCharacters[0] = (CharacterClass)selectedCharacter;
    }

    public void SelectCharacterP2(int selectedCharacter)
    {
        //PlayerNum = SelectedNum;
        //Application.LoadLevel("4 Map Select");
        selectedCharacters[1] = (CharacterClass)selectedCharacter;
    }
}
