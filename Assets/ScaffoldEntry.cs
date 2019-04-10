using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using log4net;

public class ScaffoldEntry : MonoBehaviour {

    void Awake()
    {
        this.assembleLog();
    }

    // Use this for initialization
    void Start () {
        ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        log.Info("start");
    }
	
	// Update is called once per frame
	void Update () {

	}

    private void assembleLog() {
        var logFilename = Application.dataPath + "/Logs/log4net.xml";
        var file = new System.IO.FileInfo(logFilename);
        log4net.Config.XmlConfigurator.Configure(file);
    }

}
