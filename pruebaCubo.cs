﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaCubo : MonoBehaviour
{

    int cont;
    int id = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
        Debug.Log(id);
    }

    // Update is called once per frame
    void Update()
    {
        cont++;
        Debug.Log(cont);
    }
}
