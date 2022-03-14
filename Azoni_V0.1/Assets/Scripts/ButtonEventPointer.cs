using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEventPointer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] TutorialDoorOpenerHandeler tdoh;
    private bool isPressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (isPressed) {
            switch (gameObject.name) {
                case "UI_Virtual_Button_Jump":
                    tdoh.jumpPressed = true;
                    return;
                case "UI_Virtual_Button_Sprint":
                    tdoh.runPressed = true;
                    return;
                case "ShootButton":
                    tdoh.shootPressed = true;
                    return;
                case "UI_Virtual_Joystick_Move":
                    gameObject.SetActive(false);
                    tdoh.movePressed = true;
                    return;
                case "UI_Virtual_Joystick_Look":
                    gameObject.SetActive(false);
                    tdoh.viewPressed = true;
                    return;
            }
            isPressed = false;
        }
    }
}
