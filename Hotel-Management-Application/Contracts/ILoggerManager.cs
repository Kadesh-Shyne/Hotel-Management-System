namespace Hotel_Management_Application.Contracts
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogError(string message);
        void LogWarn(string message);
        void LogDebug(string message);  
       
    }
}
