namespace firstapi1.models
{
    public class car
    {
        private Iengine _engine;
        private Iaccessories _acc;
        public car(Iengine e)
        {
            _engine = e;
            
        }
       
    }

    public interface Iengine { }
    public interface Iaccessories { }
    public class suzukiengine : Iengine { }
    public class toyotaengine : Iengine { }
    public class accessories : Iaccessories { }
}
