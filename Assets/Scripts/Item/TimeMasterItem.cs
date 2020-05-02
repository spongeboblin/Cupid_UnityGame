﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMasterItem : MonoBehaviour
{
    StageController stageController;
    // Start is called before the first frame update
    void Start()
    {
        stageController = GameObject.Find("StageController").GetComponent<StageController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        stageController.IncreaseTime(30);
    }
}
