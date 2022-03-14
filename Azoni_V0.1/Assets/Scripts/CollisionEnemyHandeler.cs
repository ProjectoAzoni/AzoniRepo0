using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemyHandeler : MonoBehaviour
{
    [SerializeField] HealtControler healthControlerEnemy;
    private void Start()
    {
        healthControlerEnemy = healthControlerEnemy.GetComponent<HealtControler>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        int attackPlayerManager;
        switch (collision.gameObject.tag) {
            
            case "Player":
                print("player");
                InvokeRepeating("RestMyHealthPlayer", 1f, 1f);
                return;
            case "B0":
                
                switch (gameObject.tag) {
                    case "E0":
                        attackPlayerManager = 10;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                    case "E1":
                        attackPlayerManager = 20;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                    case "E2":
                        attackPlayerManager = 5;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                }
                return;
            case "B1":
                
                switch (gameObject.tag)
                {
                    case "E0":
                        attackPlayerManager = 0;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                    case "E1":
                        attackPlayerManager = 0;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                    case "E2":
                        attackPlayerManager = 0;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                }
                return;
            case "B2":
                
                switch (gameObject.tag)
                {
                    case "E0":
                        attackPlayerManager = 0;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                    case "E1":
                        attackPlayerManager = 0;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                    case "E2":
                        attackPlayerManager = 0;
                        healthControlerEnemy.RestHealth(attackPlayerManager);
                        return;
                }
                return;
        }
    }

    void RestMyHealthPlayer() {
        healthControlerEnemy.RestHealth(5);
    }

}
