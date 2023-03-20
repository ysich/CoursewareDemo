using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms;

public class PuzzleItem: MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public Transform orignaParent;
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        orignaParent = transform.parent;
        Transform targetTransform = Init.showGo.transform;
        transform.SetParent(targetTransform);
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(orignaParent);
    }
}