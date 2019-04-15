
using log4net;
using System.Collections;
using UnityEngine;

class TowerColorGame : MonoBehaviour
{

    ILog logger = LogTool.getInstance().getLogger();
    public void done()
    {
        StartCoroutine(core());
    }

    //tower color核心逻辑
    //创建tower关卡
    //玩家移动tower
    //发射弹球
    //弹球移动，一直到撞上tower为止
    //获取该弹球周围的同色圆柱
    //消除同色圆柱
    //掉落悬空圆柱
    //等待玩家的下一次发射
    //跳转到步骤2
    IEnumerator core() {
        createLevel();

        while (true) {
            yield return StartCoroutine(moveTower());
            shoot();
            yield return StartCoroutine(ballMoving());
            getCylinders();
            yield return StartCoroutine(erase());
            yield return StartCoroutine(fall());
            waitInput();
        }
    }

    public void createLevel() {
        logger.Info("create tower level");
    }

    IEnumerator moveTower() {
        logger.Info("move tower");
        yield return new WaitForSeconds(2);
    }

    public void shoot() {
        logger.Info("shoot ball");
    }

    IEnumerator ballMoving() {
        logger.Info("ball is moving");
        yield return new WaitForSeconds(2);
    }

    public void getCylinders() {
        logger.Info("get same cylinders");
    }

    IEnumerator erase() {
        logger.Info("erase same cylinders");
        yield return new WaitForSeconds(1);
    }

    IEnumerator fall() {
        logger.Info("fall hanging cylinders");
        yield return new WaitForSeconds(2);
    }

    public void waitInput() {
        logger.Info("wait player input");
    }

}