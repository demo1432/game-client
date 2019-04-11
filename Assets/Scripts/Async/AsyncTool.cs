
using System.Collections;
using UnityEngine;

/**
 * 该类没有实际作用
 */
public class AsyncTool : MonoBehaviour
{

    private static AsyncTool instance;

    public static AsyncTool getInstance()
    {
        if (instance == null) {
            instance = FindObjectOfType(typeof(AsyncTool)) as AsyncTool;
        }
        return instance;
    }

    public void timeout(int times) {
        StartCoroutine(delay(times));
    }

    IEnumerator delay(int times) {
        yield return new WaitForSeconds(times);
    }

}
