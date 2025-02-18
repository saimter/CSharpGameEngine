using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20250217
{
    public class Player : GameObject
    {
        public Player(int inX, int inY, char inShape)
        {
            X = inX;
            Y = inY;
            Shape = inShape;
            Engine.Instance._posX = 0;
            Engine.Instance._posY = 0;

        }

        public override void Update()
        {
            //wasd
            //up, down, left, right`
            //GetKeyDown
            if (Input.GetKeyDown(ConsoleKey.W) || Input.GetKeyDown(ConsoleKey.UpArrow))
            {
                if(Engine.Instance._posY <= 0)
                {

                }
                else
                {
                    Engine.Instance._posY -= 1;
                    Y--;
                }

            }
            if (Input.GetKeyDown(ConsoleKey.S) || Input.GetKeyDown(ConsoleKey.DownArrow))
            {
                if (Engine.Instance._posY >= 7)
                {

                }
                else
                {
                    Engine.Instance._posY += 1;
                    Y++;
                }
            }
            if (Input.GetKeyDown(ConsoleKey.A) || Input.GetKeyDown(ConsoleKey.LeftArrow))
            {
                if (Engine.Instance._posX <= 0)
                {

                }
                else
                {
                    Engine.Instance._posX -= 1;
                    X--;
                }
            }
            if (Input.GetKeyDown(ConsoleKey.D) || Input.GetKeyDown(ConsoleKey.RightArrow))
            {
                if (Engine.Instance._posX >= 7)
                {

                }
                else
                {
                    Engine.Instance._posX += 1;
                    X++;
                }
            }
        }
    }
}
