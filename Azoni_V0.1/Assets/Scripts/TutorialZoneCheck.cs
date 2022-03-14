using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialZoneCheck : MonoBehaviour
{
    [SerializeField] TutorialDoorOpenerHandeler tdoh;
    private void OnCollisionEnter(Collision collision)
    {
        print("Good");
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print("trigger");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            switch (gameObject.name)
            {
                case "FirstCheck":
                    tdoh.firstCheck = true;
                    return;
                case "SecondCheck":
                    tdoh.secondCheck = true;
                    return;
                case "ThirdCheck":
                    tdoh.thirdCheck = true;
                    return;
            }
        }
    }
}
