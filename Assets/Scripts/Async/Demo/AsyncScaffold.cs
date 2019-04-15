using UnityEngine;

public class AsyncScaffold : MonoBehaviour {

    public void done() {
        StarGame star = FindObjectOfType(typeof(StarGame)) as StarGame;
        star.done();

        BubbleGame bubble = FindObjectOfType(typeof(BubbleGame)) as BubbleGame;
        //bubble.done();
    }

}
