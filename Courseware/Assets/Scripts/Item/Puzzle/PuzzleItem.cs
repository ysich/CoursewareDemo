using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms;

public class PuzzleItem: ItemBase,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    private Transform _orignaParent = null;
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _orignaParent = transform.parent;
        Transform targetTransform = Init.showGo.transform;
        transform.SetParent(targetTransform);
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(_orignaParent);
    }
}