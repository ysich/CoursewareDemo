using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    //拼图移动时的go拖拽时保持在最上层
    [HideInInspector]
    public static GameObject showGo = null;
    // Start is called before the first frame update
    private void Awake()
    {
        showGo = GameObject.Find("ShowItem");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
