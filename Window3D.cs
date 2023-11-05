//Nume: Rosca Stefan
//Grupa: 3131a
//Tema laborator 3

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Drawing;

namespace ConsoleApp4
{
    class Window3D : GameWindow
    {

        private KeyboardState previousKeyboard;
        private Randomizer rando;
        private Triangle3D firstTriangle;


        // CONST
        private Color DEFAULT_BACK_COLOR = Color.LightSteelBlue;


        public Window3D() : base(1280, 768, new GraphicsMode(32, 24, 0, 8))
        {
            VSync = VSyncMode.On;

            rando = new Randomizer();
            firstTriangle = new Triangle3D(rando);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            GL.Hint(HintTarget.PolygonSmoothHint, HintMode.Nicest);
            DisplayHelp();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // setare fundal
            GL.ClearColor(DEFAULT_BACK_COLOR);

            // setare viewport
            GL.Viewport(0, 0, this.Width, this.Height);

            // setare proiectie/con vizualizare
            Matrix4 perspectiva = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)this.Width / (float)this.Height, 1, 250);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspectiva);

            // setare camera
            Matrix4 cam = Matrix4.LookAt(30, 30, 30, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref cam);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState currentKeyboard = Keyboard.GetState();
            

            if (currentKeyboard[Key.Escape])
            {
                Exit();
            }

            if (currentKeyboard[Key.H] && !previousKeyboard[Key.H])
            {
                DisplayHelp();
            }

            if (currentKeyboard[Key.R] && !previousKeyboard[Key.R])
            {
                GL.ClearColor(DEFAULT_BACK_COLOR);
            }

            if (currentKeyboard[Key.B] && !previousKeyboard[Key.B])
            {
                GL.ClearColor(rando.GenerateColor());
            }

            // triangle manipulation

            if (currentKeyboard[Key.P] && !previousKeyboard[Key.P])
            {
                firstTriangle.TogglePolygonMode();
            }


            //Laborator 03

            if (currentKeyboard[Key.X] && !previousKeyboard[Key.X])
            {
                firstTriangle.DiscoMode();
            }

            if (currentKeyboard[Key.O] && !previousKeyboard[Key.O])
            {
                firstTriangle.ToggleVisibility2();
            }

            MouseState mouse = Mouse.GetState();

            if (mouse.IsButtonDown(MouseButton.Left))
            {
                Matrix4 lookat = Matrix4.LookAt(2, 3, 2, 0, 0, 0, 0, 1, 0);
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadMatrix(ref lookat);
            }

            previousKeyboard = currentKeyboard;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            firstTriangle.DrawTriangle(); 

            SwapBuffers();

        }

        private void DisplayHelp()
        {
            Console.WriteLine("\n     MENU");
            Console.WriteLine(" H - meniu ajutor");
            Console.WriteLine(" ESC - parasire aplicatie");
            Console.WriteLine(" R - resetare scena");
            Console.WriteLine(" B - schimbare culoare de fundal");
            Console.WriteLine(" P - modifica mod de desenare triunghiuri");
            Console.WriteLine(" X - Schimba culoarea triunghiului");
            Console.WriteLine(" O - afiseaza/ascunde triunghi");
            Console.WriteLine(" Hold Left Click + mouse wheel movement - ar trebui sa schimbe unghiul camerei ");
        }
    }
}
