using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // Start is called before the first frame update
    [HideInInspector] public Transform parentAfterDrag;
    public Image image;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("OnBeginDrag drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData){
        Debug.Log("OnDrag drag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("OnEndDrag drag");
        transform.SetParent(parentAfterDrag);
         image.raycastTarget = true;
    }
}
