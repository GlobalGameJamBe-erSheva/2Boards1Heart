using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct ManagerInfo
{
    public GameObject player1;
    public GameObject player2;

    public GameObject Plane1;
    public GameObject Plane2;

    public ManagerInfo(GameObject p1, GameObject p2, GameObject plane1, GameObject plane2)
	{
        player1 = p1;
        player2 = p2;
        this.Plane1 = plane1;
        this.Plane2 = plane2;
	}
}

public class SceneManager : MonoBehaviour
{


    #region Singleton

    public static SceneManager instance;

    void awake() {
        instance = this;
    }

    #endregion 

    public static GameObject player1 = GameObject.Find("Player");
    public static GameObject player2 = GameObject.Find("player 2");

    public static GameObject Plane1 = GameObject.Find("Player Plane");
    public static GameObject Plane2 = GameObject.Find("Player Plane 2");

    public static ManagerInfo GetInfo()
	{
        return new ManagerInfo(player1, player2, Plane1, Plane2);
	}

    
}
