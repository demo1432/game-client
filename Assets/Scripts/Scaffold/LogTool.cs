
using log4net;
using UnityEngine;

public class LogTool {

    private static LogTool instance = new LogTool();

    public static LogTool getInstance() {
        return instance;
    }

    public void config() {
        var logFilename = Application.dataPath + "/Logs/log4net.xml";
        var file = new System.IO.FileInfo(logFilename);
        log4net.Config.XmlConfigurator.Configure(file);
    }

    public ILog getLogger() {
        return LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }

}
