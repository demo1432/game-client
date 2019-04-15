
using log4net;
using System.Collections;
using UnityEngine;

class BubbleGame : MonoBehaviour
{

    ILog logger = LogTool.getInstance().getLogger();

    public void done()
    {
        StartCoroutine(core());
    }

    //泡泡龙核心逻辑
    //生成泡泡关卡
    //玩家移动发射台
    //发射泡泡
    //泡泡一直移动，直到撞上关卡为止
    //添加泡泡到关卡
    //获取该泡泡周围的同色泡泡
    //消除同色泡泡
    //使悬空泡泡掉落
    //等待玩家的下一次发射
    //跳转到步骤2
    IEnumerator core() {
        createLevel();

        while (true) {
            yield return StartCoroutine(moveShooter());
            shoot();
            yield return StartCoroutine(bubbleMoving());
            addBubble();
            getBubbles();
            yield return StartCoroutine(erase());
            yield return StartCoroutine(fall());
            waitInput();
        }
    }

    public void createLevel() {
        logger.Info("create bubbles level");
    }

    IEnumerator moveShooter() {
        logger.Info("move shooter");
        yield return new WaitForSeconds(1);
    }

    public void shoot() {
        logger.Info("shoot bubble");
    }

    IEnumerator bubbleMoving() {
        logger.Info("bubble is moving");
        yield return new WaitForSeconds(2);
    }

    public void addBubble() {
        logger.Info("add bubble to level");
    }

    public void getBubbles() {
        logger.Info("get same bubbles");
    }

    IEnumerator erase() {
        logger.Info("erase same bubbles");
        yield return new WaitForSeconds(1);
    }

    IEnumerator fall() {
        logger.Info("fall hanging bubbles");
        yield return new WaitForSeconds(2);
    }

    public void waitInput() {
        logger.Info("wait player input");
    }

}