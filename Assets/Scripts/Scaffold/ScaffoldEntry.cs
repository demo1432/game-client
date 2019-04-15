using System.Collections;
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
        //os.done();

        AsyncScaffold as2 = FindObjectOfType(typeof(AsyncScaffold)) as AsyncScaffold;
        as2.done();

        LambdaScaffold ls = new LambdaScaffold();
        //ls.done();

        DelegateScaffold ds = new DelegateScaffold();
        //ds.done();

        logger.Info("================= main   end ========================");
    }
	
	// Update is called once per frame
	void Update () {

	}

    IEnumerator loadRes() {
        yield return 0;

    }

}
