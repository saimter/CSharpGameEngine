namespace L20250217
{
    internal class Program
    {
        class Singleton
        {
            public int posX = 0;
            public int posY = 0;
            public int posXE = 0;
            public int posYE = 0;

            private Singleton()
            {
            }

            static Singleton instance;

            //
            static public Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                    return instance;
                }
            }
        }

        static void Main(string[] args)
        {
            Engine.Instance.Load();
            Engine.Instance.Run();

            //engine.Stop();
        }
    }
}
