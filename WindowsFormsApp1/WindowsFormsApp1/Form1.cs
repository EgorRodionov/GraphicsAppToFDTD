﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        private readonly CheckUser _user;
        public Form1(CheckUser user)
        {
            _user = user;
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#1A2D37");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoleLabel2.Text = $"{_user.Status()}";
            Loginlabel2.Text = $"{_user.Login}";
            DialogForm2 dialogForm2 = Owner as DialogForm2;
            WidthtextBox.Text = dialogForm2.WidthtextBox.Text;
            HeightTextBox.Text = dialogForm2.HeightTextBox.Text;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            
        }

        //Метод с основным вычислением
        private void FD2D_3_2()
        {
            //размер расчетной области
            int IE = int.Parse(WidthtextBox.Text);
            int JE = int.Parse(HeightTextBox.Text);
            const int NFREQS = 3;

            float[,] ga = new float[IE, JE];
            float[,] gb = new float[IE, JE];
            float[,] dz = new float[IE, JE];
            float[,] ez = new float[IE, JE];
            float[,] iz = new float[IE, JE];
            float[,] hx = new float[IE, JE];
            float[,] hy = new float[IE, JE];
            int l, n, i, j, ic, jc, nsteps, npml, m;
            float ddx, dt, T, epsz, pi, epsilon, sigma, eaf;
            float xn, xxn, xnum, xd, curl_e;
            float t0, spread, pulse;
            float[] gi2 = new float[IE];
            float[] gi3 = new float[IE];
            float[] gj2 = new float[JE];
            float[] gj3 = new float[IE];
            float[] fi1 = new float[IE];
            float[] fi2 = new float[IE];
            float[] fi3 = new float[JE];
            float[] fj1 = new float[JE];
            float[] fj2 = new float[JE];
            float[] fj3 = new float[JE];
            float[,] ihx = new float[IE, JE];
            float[,] ihy = new float[IE, JE];

            ic = IE / 2 - 10;
            jc = JE / 2 - 10;
            ddx = .01f; //Размер ячейки
            dt = ddx / 6e8f; //шаг по времени
            epsz = 8.8e-12f;
            pi = 3.14159f;

            //Инициализируем массивы

            for (j = 0; j < JE; j++)
            {
                Console.Write(j);
                Console.Write(" ");
                for (i = 0; i < IE; i++)
                {
                    dz[i, j] = 0.0f;
                    hx[i, j] = 0.0f;
                    hy[i, j] = 0.0f;
                    ihx[i, j] = 0.0f;
                    ihy[i, j] = 0.0f;
                    ga[i, j] = 1.0f;
                    Console.Write(ga[i, j]);
                }
                Console.WriteLine();
            }
            //Вычисление параметров PML
            for (i = 0; i < IE; i++)
            {
                gi2[i] = 1.0f;
                gi3[i] = 1.0f;
                fi1[i] = 0.0f;
                fi2[i] = 1.0f;
                fi3[i] = 1.0f;
            }
            for (j = 0; j < JE; j++)
            {
                gj2[j] = 1.0f;
                gj3[j] = 1.0f;
                fj1[j] = 0.0f;
                fj2[j] = 1.0f;
                fj3[j] = 1.0f;
            }

            Console.Write("Number of PML cells --> ");
            npml = int.Parse(NumberOfPmlLayersTextBox.Text);
            for (i = 0; i <= npml; i++)
            {
                xnum = npml - i;
                xd = npml;
                xxn = xnum / xd;
                xn = 0.25f * (float)Math.Pow(xxn, 3.0);
                //Console.WriteLine("\n", i, xxn, xn);
                gi2[i] = 1.0f / (1.0f + xn);
                gi2[IE - 1 - i] = 1.0f / (1.0f + xn);
                gi3[i] = (1.0f - xn) / (1.0f + xn);
                gi3[IE - i - 1] = (1.0f - xn) / (1.0f + xn);
                xxn = (xnum - .5f) / xd;
                xn = 0.25f * (float)Math.Pow(xxn, 3.0);
                fi1[i] = xn;
                fi1[IE - 2 - i] = xn;
                fi2[i] = 1.0f / (1.0f + xn);
                fi2[IE - 2 - i] = 1.0f / (1.0f + xn);
                fi3[i] = (1.0f - xn) / (1.0f + xn);
                fi3[IE - 2 - i] = (1.0f - xn) / (1.0f + xn);
            }

            for (j = 0; j <= npml; j++)
            {
                xnum = npml - j;
                xd = npml;
                xxn = xnum / xd;
                xn = 0.25f * (float)Math.Pow(xxn, 3.0);
                //Console.WriteLine("\n", i, xxn, xn);
                gj2[j] = 1.0f / (1.0f + xn);
                gj2[JE - 1 - j] = 1.0f / (1.0f + xn);
                gj3[j] = (1.0f - xn) / (1.0f + xn);
                gj3[JE - j - 1] = (1.0f - xn) / (1.0f + xn);
                xxn = (xnum - .5f) / xd;
                xn = 0.25f * (float)Math.Pow(xxn, 3.0);
                fj1[j] = xn;
                fj1[JE - 2 - j] = xn;
                fj2[j] = 1.0f / (1.0f + xn);
                fj2[JE - 2 - j] = 1.0f / (1.0f + xn);
                fj3[j] = (1.0f - xn) / (1.0f + xn);
                fj3[JE - 2 - j] = (1.0f - xn) / (1.0f + xn);
            }
            /*
                        Console.WriteLine("gi + fi \n");
                        for (i = 0; i < IE; i++)
                        {
                            Console.WriteLine("\n", i, gi2[i], gi3[i]);
                            Console.WriteLine("\n ", fi1[i], fi2[i], fi3[i]);
                        }

                        Console.WriteLine("gj + fj \n");
                        for (j = 0; j < JE; j++)
                        {
                            Console.WriteLine("\n", j, gj2[j], gj3[j]);
                            Console.WriteLine("\n ", fj1[j], fj2[j], fj3[j]);

                        }
            */
            t0 = 40.0f;
            spread = 12.0f;
            T = 0;
            nsteps = 1;

            while (nsteps > 0)
            {
                Console.WriteLine("nsteps --> ");
                nsteps = int.Parse(SpatialGridStepTextBox.Text);
                //Console.WriteLine("\n", nsteps);
                for (n = 1; n <= nsteps; n++)
                {
                    T += 1;
                    //Начало основного цикла FDTD
                    //Вычисление поля Dz
                    for (j = 1; j < IE; j++)
                    {
                        for (i = 1; i < IE; i++)
                        {
                            if ((i == (ic - 1)) && (j == (jc - 1)))
                                Console.WriteLine();
                            dz[i, j] = gi3[i] * gj3[j] * dz[i, j]
                            + gi2[i] * gj2[j] * .5f * (hy[i, j] - hy[i - 1, j]
                            - hx[i, j] + hx[i, j - 1]);
                        }
                    }
                    //Синусоидальный источник
                    pulse = (float)Math.Exp(-.5f * Math.Pow((T - t0) / spread, 2.0));
                    dz[ic, jc] = pulse;
                    //Вычисление поля Ez
                    //Оставьте ребра Ez равными 0, как часть PML
                    for (j = 1; j < JE - 1; j++)
                    {
                        for (i = 1; i < IE - 1; i++)
                        {
                            ez[i, j] = ga[i, j] * dz[i, j];
                        }
                    }
                    //Console.WriteLine("\n ", T, ez[ic, jc]);
                    //Вычисление поля Hx
                    for (j = 0; j < JE - 1; j++)
                    {
                        for (i = 0; i < IE; i++)
                        {
                            curl_e = ez[i, j] - ez[i, j + 1];
                            ihx[i, j] = ihx[i, j] + fi1[i] * curl_e;
                            hx[i, j] = fj3[j] * hx[i, j]
                            + fj2[j] * .5f * (curl_e + ihx[i, j]);
                        }
                    }
                    // Вычисление поля Hy
                    for (j = 0; j < JE - 1; j++)
                    {
                        for (i = 0; i < IE - 1; i++)
                        {
                            curl_e = ez[i + 1, j] - ez[i, j];
                            ihy[i, j] = ihy[i, j] + fj1[j] * curl_e;
                            hy[i, j] = fi3[i] * hy[i, j]
                            + fi2[i] * .5f * (curl_e + ihy[i, j]);
                        }
                    }

                    // Конец основного цикла FDTD
                }
                for (j = 1; j < JE; j++)
                {
                    Console.Write(j);
                    for (i = 1; i < IE; i++)
                    {
                        Console.Write(ez[i, j]);
                    }
                    Console.WriteLine();
                }
                //Write the E field out to a file "Ez"
                string path = "fd2d_3_2.txt";
                try
                {
                    StreamWriter sw = new StreamWriter(path);
                    for (j = 0; j < JE; j++)
                    {
                        for (i = 0; i < IE; i++)
                        {
                            sw.Write(ez[i, j]);
                            sw.Write(" ");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                    Console.WriteLine("T = \n ", T);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }
        }
    }
}
