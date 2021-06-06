using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _Instance = null;

    public static UIManager instance { get { return _Instance; } }

    [SerializeField]
    private GameObject[] playerHP_Objs = null;

    private void Awake()
    {
        _Instance = this;
    }

    public void playerHP()
    {
        int minusHP = 3 - DataManager.instance.playerHP;
            for (int i = 0; i < minusHP; i++)
        {
            playerHP_Objs[i].SetActive(false);
        }
    }
}