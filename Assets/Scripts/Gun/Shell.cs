﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    private Transform m_Transform;

    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        m_Transform.Rotate(Vector3.up * Random.Range(10, 30));
    }
}
