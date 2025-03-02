using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowXY : MonoBehaviour
{
    private Transform camTrans;

    void Start()
    {
        camTrans = Camera.main.transform;
    }

    void Update()
    {
        transform.position = camTrans.position;
    }
}
