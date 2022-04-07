using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL.SceneGraph.Effects;
using SharpGL.SceneGraph.Primitives;
using SharpGL.Serialization.Wavefront;
using System.IO;
using SharpGL;

namespace Graficacion_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl1_Load(object sender, EventArgs e)
        {

        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.ClearColor(0, 0, 0, 0);
        }

        private void openGLControl1_Resize(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            gl.LoadIdentity();
            gl.Perspective(30.0f, (Double)Width / (Double)Height, 5, 100);
            gl.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;
            gl.LoadIdentity();

            //Primera figura
            gl.Translate(-1.55f, 0f, -6f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.5f, 1.5f, 0.0f);
                gl.Vertex(0.5f, 1.5f, 0.0f);
                gl.Vertex(0.5f, -1.5f, 0.0f);
                gl.Vertex(-0.5f, -1.5f, 0.0f);
            }
            gl.End();

            //Segunda figura
            gl.Translate(1.02f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.5f, 1.5f, 0.0f);
                gl.Vertex(0.5f, 1.5f, 0.0f);
                gl.Vertex(0.5f, -1.5f, 0.0f);
                gl.Vertex(-0.5f, -1.5f, 0.0f);
            }
            gl.End();

            //Tercera figura
            gl.Translate(1.02f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.5f, 1.5f, 0.0f);
                gl.Vertex(0.5f, 1.5f, 0.0f);
                gl.Vertex(0.5f, -1.5f, 0.0f);
                gl.Vertex(-0.5f, -1.5f, 0.0f);
            }
            gl.End();

            //Cuarta figura
            gl.Translate(1.02f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.5f, 1.5f, 0.0f);
                gl.Vertex(0.5f, 1.5f, 0.0f);
                gl.Vertex(0.5f, -1.5f, 0.0f);
                gl.Vertex(-0.5f, -1.5f, 0.0f);
            }
            gl.End();
        }
    }
}
