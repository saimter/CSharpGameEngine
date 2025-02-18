using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20250217
{
    public class Monster : GameObject
    {
        private Random rand = new Random();

        public Monster(int inX, int inY, char inShape)
        {
            X = inX;
            Y = inY;
            Shape = inShape;

            Engine.Instance._posXE = 3;
            Engine.Instance._posYE = 4;

            //Engine.Instance._XE = -1;
            //Engine.Instance._YE = -1;


        }

        public override void Update()
        {
            int Direction = rand.Next(0, 4);

            if (Direction == 0)
            {
                if(Engine.Instance._posYE > 0)
                {
                    Engine.Instance._posYE -= 1;
                    Y--;
                    Engine.Instance._YE = Y;
                }
            }
            if (Direction == 1)
            {
                if (Engine.Instance._posYE < 7)
                {
                    Engine.Instance._posYE += 1;
                    Y++;
                    Engine.Instance._YE = Y;
                }
            }

            if (Direction == 2)
            {
                if (Engine.Instance._posXE > 0)
                {
                    Engine.Instance._posXE -= 1;
                    X--;
                    Engine.Instance._XE = X;
                }
            }
            if (Direction == 3)
            {
                if (Engine.Instance._posXE < 7)
                {
                    Engine.Instance._posXE += 1;
                    X++;
                    Engine.Instance._XE = X;
                }
            }
        }
    }
}
