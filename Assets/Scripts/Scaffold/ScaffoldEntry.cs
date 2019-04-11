﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using log4net;

public class ScaffoldEntry : MonoBehaviour {

    void Awake()
    {
        LogTool.getInstance().config();
    }

    // Use this for initialization
    void Start () {
        ILog logger = LogTool.getInstance().getLogger();

        logger.Info("================= main start ========================");

        ObserverScaffold os = new ObserverScaffold();
        os.done();

        logger.Info("================= main   end ========================");
    }
	
	// Update is called once per frame
	void Update () {

	}

}