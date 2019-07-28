using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    public static int PlayerNum;
    public void CharacterSelectFunction (int SelectedNum)
    {
        PlayerNum = SelectedNum;
        Application.LoadLevel("3 Char Select2");

    }
}
