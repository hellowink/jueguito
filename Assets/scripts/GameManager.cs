using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private playerMovement _playerMovement;
    public playerMovement playerMovement
    {
        get { return _playerMovement; }
        set { _playerMovement = value; }
    }

    private List<enemy> _enemies = new();

    public List<enemy> enemies
    {
        get { return _enemies; }
        set { _enemies = value; }
    }
}
