using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using log4net;

public class demo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        log.Info("start demo");


        log.Info("end demo");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
