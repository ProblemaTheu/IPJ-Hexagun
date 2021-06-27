using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagement : MonoBehaviour
{
    #region Singleton
    public static PlayerManagement instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player1;

}
