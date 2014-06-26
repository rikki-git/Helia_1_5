﻿// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Drawing;
using System.Windows.Forms;

using OpenTK.Graphics.OpenGL;

namespace Helia_1_5_client
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        Render render;

        private void FormGame_Load(object sender, EventArgs e)
        {
            render = new Render();
            render.Resize(glControl1.Width, glControl1.Height);
            timer1.Enabled = true;
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            render.Resize(glControl1.Width, glControl1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            render.main();
            glControl1.SwapBuffers();
        }
    }
}
