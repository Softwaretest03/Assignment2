namespace Library;
public interface ILogFile {
    public void LogDoorLocked();
    public void LogDoorUnlocked();
}
public class LogFile : ILogFile
{
    public string path = StationControl.logFile;
    public void LogDoorLocked(int id){
        //write to log
    }
    public void LogDoorUnlocked(int id){
        //write to log
    }
}