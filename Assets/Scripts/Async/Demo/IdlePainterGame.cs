
using log4net;
using System.Collections;
using UnityEngine;

class IdlePainterGame : MonoBehaviour
{

    ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public void done() {
        StartCoroutine(core());
    }

    //idle painter核心逻辑
    //生成多边形关卡
    //设置起点多边形
    //从起点多边形开始，按广度遍历顺序将其他多边形放入队列
    //从队列中获取多边形
    //对多边形进行涂色
    //跳转到步骤4
    IEnumerator core() {
        createLevel();
        setOrigin();
        sortPolygons();

        while (true) {
            getPolygon();
            yield return StartCoroutine(paint());
        }
    }

    public void createLevel() {
        logger.Info("create polygons level");
    }

    public void setOrigin() {
        logger.Info("set level origin polygon");
    }

    public void sortPolygons() {
        logger.Info("put polygons in queue");
    }

    public void getPolygon() {
        logger.Info("get polygon from queue");
    }

    IEnumerator paint() {
        logger.Info("paint polygon");
        yield return new WaitForSeconds(2);
    }

}