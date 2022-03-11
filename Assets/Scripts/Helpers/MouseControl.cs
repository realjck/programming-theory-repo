using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseControl : MonoBehaviour
    ,IPointerDownHandler
    ,IDragHandler
{
    [SerializeField] private GameObject cameraObject;
    [SerializeField] private float sensitivity = 0.2f;
    private Vector3 mouseReference;
    private Vector3 mouseOffset;
    // rotate cameraObject by click and drag on this:
    public void OnPointerDown(PointerEventData eventData){
        mouseReference = Input.mousePosition;
    }
    public void OnDrag(PointerEventData eventData){
        mouseOffset = (Input.mousePosition - mouseReference);
        Vector3 rotation = new Vector3(0, -(mouseOffset.x * sensitivity), 0);
        cameraObject.transform.Rotate(rotation);
        mouseReference = Input.mousePosition;
    }
}
