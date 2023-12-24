using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenTK_winforms_z02
{
    class Pyramid
    {
        Pyramid()
        {
            
        }
        public void Draw()
        {

            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(30.0f, 0.0f, 0.0f);
            GL.Vertex3(0.0f, 30.0f, 0.0f);
            GL.Color3(0.0f, 30.0f, 0.0f);
            GL.Vertex3(-30.0f, -30.0f, 30.0f);
            GL.Color3(0.0f, 0.0f, 10.0f);
            GL.Vertex3(30.0f, -30.0f, 30.0f);


            GL.Color3(30.0f, 0.0f, 0.0f);
            GL.Vertex3(0.0f, 30.0f, 0.0f);
            GL.Color3(0.0f, 0.0f, 30.0f);
            GL.Vertex3(30.0f, -30.0f, 30.0f);
            GL.Color3(0.0f, 30.0f, 0.0f);
            GL.Vertex3(30.0f, -30.0f, -30.0f);


            GL.Color3(30.0f, 0.0f, 0.0f);
            GL.Vertex3(0.0f, 30.0f, 0.0f);
            GL.Color3(0.0f, 30.0f, 0.0f);
            GL.Vertex3(30.0f, -30.0f, -30.0f);
            GL.Color3(0.0f, 0.0f, 30.0f);
            GL.Vertex3(-30.0f, -30.0f, -30.0f);


            GL.Color3(30.0f, 0.0f, 0.0f);
            GL.Vertex3(0.0f, 30.0f, 0.0f);
            GL.Color3(0.0f, 0.0f, 30.0f);
            GL.Vertex3(-30.0f, -30.0f, -30.0f);
            GL.Color3(0.0f, 30.0f, 0.0f);
            GL.Vertex3(-30.0f, -30.0f, 30.0f);
            GL.End();
        }
        public void DrawWithTexture( bool brick, int colorTex, int []textures)
        {
            if (brick == true)
            {
                GL.BindTexture(TextureTarget.Texture2D, textures[0]);
            }
            else
            {
                GL.BindTexture(TextureTarget.Texture2D, textures[1]);
            }

            switch (colorTex)
            {
                case 0:
                    GL.Color3(Color.White);      //Culoarea albă permite maparea texturii fără alterarea culorii originale.
                    break;
                case 1:
                    GL.Color3(Color.FromArgb(0, 255, 0, 0));
                    break;
                case 2:
                    GL.Color3(Color.FromArgb(0, 0, 0, 255));
                    break;
            }

            GL.Begin(PrimitiveType.Triangles);           
            GL.TexCoord2(0.0, 1.0);     
            GL.Vertex3(0.0f, 30.0f, 0.0f);
            GL.TexCoord2(1.0, 0.0);    
            GL.Vertex3(-30.0f, -30.0f, 30.0f);
            GL.TexCoord2(0.0, 0.0);     
            GL.Vertex3(30.0f, -30.0f, 30.0f);

            GL.TexCoord2(0.0, 1.0);   
            GL.Vertex3(0.0f, 30.0f, 0.0f);
            GL.TexCoord2(1.0, 0.0);  
            GL.Vertex3(30.0f, -30.0f, 30.0f);
            GL.TexCoord2(0.0, 0.0);     
            GL.Vertex3(30.0f, -30.0f, -30.0f);

            GL.TexCoord2(0.0, 1.0); 
            GL.Vertex3(0.0f, 30.0f, 0.0f);
            GL.TexCoord2(1.0, 0.0);  
            GL.Vertex3(30.0f, -30.0f, -30.0f);
            GL.TexCoord2(0.0, 0.0); 
            GL.Vertex3(-30.0f, -30.0f, -30.0f);

            GL.TexCoord2(0.0, 1.0);   
            GL.Vertex3(0.0f, 30.0f, 0.0f);
            GL.TexCoord2(1.0, 0.0);   
            GL.Vertex3(-30.0f, -30.0f, -30.0f);
            GL.TexCoord2(0.0, 0.0);  
            GL.Vertex3(-30.0f, -30.0f, 30.0f);
            GL.End();  
        }
    }
}
