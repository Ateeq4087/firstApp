namespace firstapi1.models
{
    public interface Iapilogger 
    {
        void log (string message);
    }
    public class apilogger:Iapilogger
    {

        public void log(string message)
        {
            Console.WriteLine($"{DateTime.Now}:{message}");
        }
    }
    public class fileapilogger : Iapilogger
    {
        private string _filename;

        public fileapilogger()
        {
            _filename = $"Log_{DateTime.Now.ToFileTime()}.log";
            File.WriteAllText(_filename, "This is a log file"+Environment.NewLine);
        }
        public void log(string message)
        {
            File.AppendAllText(_filename, $"{ DateTime.Now}: {message}");
            File.AppendAllText(_filename, Environment.NewLine);

        }
    }
}
