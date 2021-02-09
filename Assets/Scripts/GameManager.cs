using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Ship player1Prefab;
    [SerializeField] private Ship player2Prefab;

    public static Ship Player1Prefab
    {
        get
        {
            return Instance.player1Prefab;
        }
        set
        {
            Instance.player1Prefab = value;
        }
    }

    public static Ship Player2Prefab
    {
        get
        {
            return Instance.player1Prefab;
        }
        set
        {
            Instance.player1Prefab = value;
        }
    }
}
