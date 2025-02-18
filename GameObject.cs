using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace L20250217
{
    public class GameObject
    {
        public int X;
        public int Y;
        public char Shape; //Mesh, Spirte

        public virtual void Update()
        {
            ////Postion(X, Y);
            //Engine.Instance._posX = X;
            //Engine.Instance._posY = Y;
        }

        public virtual void Render()
        {
            ////X,Y 위치에 Shape 출력
            Console.SetCursorPosition(X, Y);
            Console.Write(Shape);
        }
        
    }
}
