using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] ProjectileGunTutorial pgt;
    public void OnPointerDown(PointerEventData eventData)
    {
        pgt.shooting = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pgt.shooting = false;
    }
}
