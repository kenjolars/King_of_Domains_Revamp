using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect2 : MonoBehaviour
{
    public static int PlayerNum2;
    public void CharacterSelectFunction2(int SelectedNum)
    {
        PlayerNum2 = SelectedNum;
        Application.LoadLevel("4 Map Select");

    }
}
