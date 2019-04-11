
using log4net;
using System;

public class ExObserver : IObserver
{

    public void onNotify(int code, object data)
    {
        ILog logger = LogTool.getInstance().getLogger();

        string str = Convert.ToString(data);
        logger.Info("ExObserver onNotify  data = " + str);
    }

}
