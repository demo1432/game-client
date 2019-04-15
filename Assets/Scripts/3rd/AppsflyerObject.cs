using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppsflyerObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //appsflyer
        AppsFlyer.init("qHqxrg7eWBBn6pHFsqqPU7");

        //com.balloon33.tower
        //com.balloon33.polysphere

        //com.balloon33.painter
        //com.balloon33.block
        //com.balloon33.knock
        //com.balloon33.puzzle
        AppsFlyer.setAppID("com.balloon33.tower");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
