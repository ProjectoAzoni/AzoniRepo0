using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDoorOpenerHandeler : MonoBehaviour
{
    [SerializeField] Animator door0, door1, door2, character0, character1, character2, panelTextInfo, panelEnemyTest, panelFinal, textInfo, textEnemys, textFinal;
    [SerializeField] GameObject checkCanvas1, checkCanvas2, checkCanvas3;
    public bool jumpPressed, runPressed, shootPressed, movePressed, viewPressed, firstCheck, secondCheck, thirdCheck;
    private bool isOpenedDoor0, isOpenedDoor1, isOpenedDoor2;
    void Update()
    {
        ActivateAnimationDoor0();
        CheckFirstZone();
        CheckSecondZone();
        CheckThirdZone();
    }

    public void ActivateAnimationDoor0() {
        if (!isOpenedDoor0) {
            if (jumpPressed && runPressed && shootPressed && movePressed && viewPressed) {
                door0.SetTrigger("Open");
                isOpenedDoor0 = true;
            }
        }
    }
    public void CheckFirstZone() {
        if (isOpenedDoor0 && firstCheck) {
            checkCanvas1.SetActive(true);
            character0.SetTrigger("Open");
            panelTextInfo.SetTrigger("Open");
            textInfo.SetTrigger("Open");
            firstCheck = false;
        }
    }

    public void ActivateAnomationDoor1() {
        if (!isOpenedDoor1) {
            door1.SetTrigger("Open");
            isOpenedDoor1 = true;
        }
    }
    public void CheckSecondZone()
    {
        if (isOpenedDoor1 && secondCheck)
        {
            checkCanvas2.SetActive(true);
            character1.SetTrigger("Open");
            panelEnemyTest.SetTrigger("Open");
            textEnemys.SetTrigger("Open");
            secondCheck = false;
        }
    }
    public void ActivateAnimationDoor2()
    {
        if (!isOpenedDoor2)
        {
            door2.SetTrigger("Open");
            isOpenedDoor2 = true;
        }
    }
    public void CheckThirdZone()
    {
        if (isOpenedDoor2 && thirdCheck)
        {
            checkCanvas3.SetActive(true);
            character2.SetTrigger("Open");
            panelFinal.SetTrigger("Open");
            textFinal.SetTrigger("Open");
            thirdCheck = false;
        }
    }
}
