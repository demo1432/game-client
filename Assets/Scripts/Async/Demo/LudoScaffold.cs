


using log4net;
using System.Collections;
using UnityEngine;

class LudoScaffold : MonoBehaviour
{

    ILog logger = LogTool.getInstance().getLogger();

    public void done() {
        StartCoroutine(core());
    }

    //飞行棋核心逻辑
    //
    IEnumerator core() {
        yield return 0;
    }



}
