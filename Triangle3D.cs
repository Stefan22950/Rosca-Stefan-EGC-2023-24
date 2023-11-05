//Nume: Rosca Stefan
//Grupa: 3131a
//Tema laborator 3

using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.IO;

namespace ConsoleApp4
{
    class Triangle3D
    {

        private Vector3 pointA_;//Laborator03
        private Vector3 pointB_;//Laborator03
        private Vector3 pointC_;//Laborator03
        private Color color;
        private bool visibility;
        private float linewidth;
        private float pointsize;
        private Randomizer localRando;
        private PolygonMode polMode;

        private bool visibility2; //Laborator  03

        public Triangle3D(Randomizer _r)
        {
            localRando = _r;

            pointA_ = _r.citestefisier(); //Laborator03
            pointB_ = _r.citestefisier(); //Laborator03 
            pointC_ = _r.citestefisier(); //Laborator03
            color = _r.GenerateColor();

            Inits();
        }

        private void Inits()
        {
            visibility = true;
            visibility2 = true;
            linewidth = 3.0f;
            pointsize = 3.0f;
            polMode = PolygonMode.Fill;
        }

        

        public void ToggleVisibility()
        {
            visibility = !visibility;
        }

        public void TogglePolygonMode()
        {
            if (polMode == PolygonMode.Fill)
            {
                polMode = PolygonMode.Line;
            }
            else if (polMode == PolygonMode.Line)
            {
                polMode = PolygonMode.Point;
            }
            else
            {
                polMode = PolygonMode.Fill;
            }
        }

        public void DiscoMode()
        {
            color = localRando.GenerateColor();
        }

        /// Laborator 03

        public void DrawTriangle()
        {
            if(visibility2)
            {
                GL.PointSize(pointsize);
                GL.LineWidth(linewidth);
                GL.PolygonMode(MaterialFace.FrontAndBack, polMode);
                GL.Begin(PrimitiveType.Triangles);
                GL.Color3(color);
                GL.Vertex3(pointA_);
                GL.Vertex3(pointB_);
                GL.Vertex3(pointC_);
                GL.End();
            }
        }
      
        public void ToggleVisibility2()
        {
            visibility2 = !visibility2;
        }


    }
}
