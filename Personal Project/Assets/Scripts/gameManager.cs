using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
   public static gameManager _gameManager {  get; private set; }
   public Health _playerHealth = new Health(100, 100);
    void Awake()
    {
        if (_gameManager!=null && _gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            _gameManager = this;
        }
    }

}
