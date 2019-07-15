using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNew : MonoBehaviour {

    public void NewSceneLoader (int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
