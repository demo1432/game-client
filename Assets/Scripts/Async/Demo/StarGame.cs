
using log4net;
using System.Collections;
using UnityEngine;

public class StarGame : MonoBehaviour
{

    ILog logger = LogTool.getInstance().getLogger();

    public void done() {
        StartCoroutine(core());
    }

    //消灭星星的核心逻辑
    //根据玩家输入找到星星对象
    //获取该对象周围的同色星星
    //消除同色星星
    //使悬空星星掉落
    //等待新的玩家输入
    IEnumerator core()
    {
        this.getInput();
        this.getStars();
        yield return StartCoroutine(erase());
        yield return StartCoroutine(fall());
        this.waitInput();
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

    IEnumerator fall()
    {
        logger.Info("fall other stars");
        yield return new WaitForSeconds(1);
    }

    public void waitInput()
    {
        logger.Info("wait player input");
    }

}