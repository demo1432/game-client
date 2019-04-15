
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
        System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
        System.Diagnostics.StackFrame[] sfs = st.GetFrames();
        return LogManager.GetLogger(sfs[1].GetMethod().DeclaringType);

        //return LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }

}
