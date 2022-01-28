using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    #region Singleton

    public static SceneManager instance;

    void awake() {
        instance = this;
    }

    #endregion 

    public GameObject player;
}
