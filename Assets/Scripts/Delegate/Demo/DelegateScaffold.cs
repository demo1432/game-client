
using log4net;
using System;

public class DelegateScaffold {

    ILog logger = LogTool.getInstance().getLogger();

    public void done()
    {

        method = new MethodDelegate(Add);

        //logger.Info("DelegateScaffold == " + method(5, 2));


        MyDelegate test = new MyDelegate(MyDelegate1);

        DogShow = new DogShowEventHandler(show);

        //DogShow += show;

        DogShow();
    }

    public delegate void DogShowEventHandler();

    public event DogShowEventHandler DogShow;

    public void show() {
        logger.Info("show");
    }

    public int MyDelegate1(string s) {
        return 0;
    }

    private int Add(int x, int y)
    {
        return x + y;
    }

    public delegate int MethodDelegate(int x, int y);

    private static MethodDelegate method;

    public delegate int MyDelegate(string s);

    //Action
    //Func
    //predicase

}
