﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraForms
{
    public partial class Form1 : Form
    {
        WebCam oWebCam;
        public Form1()
        {
                InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                oWebCam = new WebCam();
                oWebCam.Container = pictureBox1;
            oWebCam.ComboBox = comboBox1;
            oWebCam.Load();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            oWebCam.OpenConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oWebCam.ImageSettings();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            oWebCam.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            oWebCam.Settings();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oWebCam.SaveImage();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oWebCam.StartRecording();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            oWebCam.StopRecording();
        }
    }
}
