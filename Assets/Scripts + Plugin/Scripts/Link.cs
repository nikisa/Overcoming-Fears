﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour {

    public float borderWidth = .02f;

    public float lineThickness = 0.5f;

    public float scaleTime = 0.25f;

    public float delay = 0.1f;

    public iTween.EaseType easeType = iTween.EaseType.easeInOutExpo;
    
    public void DrawLink(Vector3 startPos , Vector3 endPos) {
        transform.localScale = new Vector3(lineThickness, 1f, 0f);

        Vector3 dirVector = endPos - startPos;

<<<<<<< HEAD
        float zScale = dirVector.magnitude - borderWidth * 2;
=======
        float zScale = dirVector.magnitude - borderWidth * 10;
>>>>>>> 28a4a5eb641a63256f509b35829f8aaca21dbf7d

        Vector3 newScale = new Vector3(lineThickness, 1f, zScale);

        transform.rotation = Quaternion.LookRotation(dirVector);

        transform.position = startPos + (transform.forward * borderWidth);

        iTween.ScaleTo(gameObject, iTween.Hash(
            "time", scaleTime,
            "scale", newScale,
            "easytype", easeType,
            "delay", delay
            ));
    }
}
