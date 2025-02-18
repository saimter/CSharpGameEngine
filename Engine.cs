using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20250217
{
    public class Engine
    {
        private Engine()
        {

        }

        static protected Engine instance;

        static public Engine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Engine();
                }

                return instance;
            }
        }


        protected bool isRunning = true;
        public int _posX = -1, _posY = -1;
        public int _posXE = -1, _posYE = -1;

        public int _XE = -1, _YE = -1;

        public void Load()
        {
            //file에서 로딩
            string[] scene = {
                "**********",
                "*P       *",
                "*        *",
                "*        *",
                "*        *",
                "*   M    *",
                "*        *",
                "*        *",
                "*       G*",
                "**********"
            };

            world = new World();

            for (int y = 0; y < scene.Length; y++)
            {
                for (int x = 0; x < scene[y].Length; x++)
                {
                    if ( scene[y][x] == '*' )
                    {
                        Wall wall = new Wall(x, y, scene[y][x]);
                        world.Instanciate(wall);
                    }
                    else if (scene[y][x] == ' ')
                    {
                        Floor floor = new Floor(x, y, scene[y][x]);
                        world.Instanciate(floor);
                    }
                    else if (scene[y][x] == 'P')
                    {
                        Player player = new Player(x, y, scene[y][x]);
                        world.Instanciate(player);
                    }
                    else if (scene[y][x] == 'M')
                    {
                        Monster monster = new Monster(x, y, scene[y][x]);
                        world.Instanciate(monster);
                    }
                    else if (scene[y][x] == 'G')
                    {
                        Goal goal = new Goal(x, y, scene[y][x]);
                        world.Instanciate(goal);
                    }
                }
            }
        }

        public void ProcessInput()
        {
            Input.Process();
        }


        protected void Update()
        {
            world.Update();
        }

        protected void Render()
        {
            Console.Clear();
            world.Render();
            Console.WriteLine($"");

            if ((_posX == _posXE) && (_posY == _posYE))
            {
                Console.WriteLine($"GAME OVER");
            }
            else if ((_posX == 7) && (_posY == 7))
            {
                Console.WriteLine($"STAGE CLEAR!!!");
            }
            else {
                Console.WriteLine($"{_posX},{_posY}");
                Console.WriteLine($"{_posXE},{_posYE}");
            }
        }


        public void Run()
        {
            while (isRunning)
            {
                ProcessInput();
                Update();
                Render();
            }
        }


        public World world;
    }
}
