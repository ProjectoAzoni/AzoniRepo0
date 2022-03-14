using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTestEnemyCheck : MonoBehaviour
{
    [SerializeField] GameObject[] testEnemys;
    [SerializeField] TutorialDoorOpenerHandeler tdoh;
    int enemyCount = 0;

    void Update()
    {
        CheckEnemysRemaning();
    }

    public void CheckEnemysRemaning() {
        if (testEnemys[0].gameObject.activeInHierarchy == false && testEnemys[1].gameObject.activeInHierarchy == false && testEnemys[2].gameObject.activeInHierarchy == false && testEnemys[3].gameObject.activeInHierarchy == false) {
            tdoh.ActivateAnimationDoor2();
        }
        //the shit down here didn't work and i don't know why
        /*if (enemyCount < testEnemys.Length && enemyCount >= 0 )
        {
            for (int i = 0; i < testEnemys.Length; i++)
            {
                if (testEnemys[i].gameObject.activeInHierarchy == false)
                {
                    enemyCount = enemyCount + 1;
                }
            }
        }
        else if (enemyCount == testEnemys.Length){
            tdoh.ActivateAnimationDoor2();
        }*/
    
    }
}
