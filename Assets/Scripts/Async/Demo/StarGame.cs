
using log4net;
using System.Collections;
using UnityEngine;

public class StarGame : MonoBehaviour
{

    ILog logger = LogTool.getInstance().getLogger();

    public void done() {
        StartCoroutine(core());
    }

    //消灭星星核心逻辑
    //生成星星关卡
    //根据玩家输入位置找到对应的星星
    //获取该星星周围的同色星星
    //消除同色星星
    //补充星星
    //使悬空星星掉落
    //等待玩家的下一次输入
    //跳转到步骤2
    IEnumerator core()
    {
        createLevel();

        while (true) {
            getInput();
            getStars();
            yield return StartCoroutine(erase());
            supply();
            yield return StartCoroutine(fall());
            yield return StartCoroutine(waitInput());
        }
    }

    public void createLevel() {
        logger.Info("create stars level");
    }

    public void getInput()
    {
        logger.Info("get input star");
    }

    public void getStars()
    {
        logger.Info("get same stars");
    }

    IEnumerator erase()
    {
        logger.Info("erase same stars");
        yield return new WaitForSeconds(1);
    }

    public void supply() {
        logger.Info("supply stars");
    }

    IEnumerator fall()
    {
        logger.Info("fall hanging stars");
        yield return new WaitForSeconds(2);
    }

    IEnumerator waitInput() {
        logger.Info("wait player input");
        yield return new WaitForSeconds(2);
    }

}
