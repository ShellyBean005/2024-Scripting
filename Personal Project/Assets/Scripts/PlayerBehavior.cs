using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            PlayerTakeDamage(10);
            Debug.Log(gameManager._gameManager._playerHealth.health);
        }
    }

    private void PlayerTakeDamage(int damage)
    {
        gameManager._gameManager._playerHealth.Damage(damage);
    }

    private void PlayerTakeHeal(int heal) 
    {
        gameManager._gameManager._playerHealth.Heal(heal);
    }
}
