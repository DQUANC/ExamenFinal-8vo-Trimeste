using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_DQuan
{
    public partial class Form1 : Form
    {
        public string[,] Matriz1 = new string[5, 5]; 
        public string[,] Matriz2 = new string[5, 5]; 
        public string[,] Matriz3 = new string[5, 5];
        int tamanho = 5;
        int varAleatory1 = 0;
        int varAleatory2 = 0;
        int varAleatory3 = 0;
        int varAleatory4 = 0;
        int varAleatory5 = 0;
        int varAleatory6 = 0;
        int varAleatory7 = 0;
        int varAleatory8 = 0;
        int varAleatory9 = 0;
        int varAleatory0 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //Tablero 1

        public void Random1()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory1 = rnd0.Next(0, 15);
                Thread.Sleep(20);
                switch (i)
                {
                    case 0:
                        Matriz1[0, 0] = Convert.ToString(varAleatory1);
                        if (varAleatory1 % 2 != 0) { label1.ForeColor = Color.Red; }
                        else { label1.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz1[0, 1] = Convert.ToString(varAleatory1);
                        if (varAleatory1 % 2 != 0) { label2.ForeColor = Color.Red; }
                        else { label2.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz1[0, 2] = Convert.ToString(varAleatory1);
                        if (varAleatory1 % 2 != 0) { label3.ForeColor = Color.Red; }
                        else { label3.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz1[0, 3] = Convert.ToString(varAleatory1);
                        if (varAleatory1 % 2 != 0) { label4.ForeColor = Color.Red; }
                        else { label4.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz1[0, 4] = Convert.ToString(varAleatory1);
                        if (varAleatory1 % 2 != 0) { label5.ForeColor = Color.Red; }
                        else { label5.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void Random2()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory2 = rnd0.Next(16, 35);
                Thread.Sleep(20);
                switch (i)
                {
                    case 0:
                        Matriz1[1, 0] = Convert.ToString(varAleatory2);
                        if (varAleatory2 % 2 != 0) { label10.ForeColor = Color.Red; }
                        else { label10.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz1[1, 1] = Convert.ToString(varAleatory2);
                        if (varAleatory2 % 2 != 0) { label9.ForeColor = Color.Red; }
                        else { label9.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz1[1, 2] = Convert.ToString(varAleatory2);
                        if (varAleatory2 % 2 != 0) { label8.ForeColor = Color.Red; }
                        else { label8.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz1[1, 3] = Convert.ToString(varAleatory2);
                        if (varAleatory2 % 2 != 0) { label7.ForeColor = Color.Red; }
                        else { label7.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz1[1, 4] = Convert.ToString(varAleatory2);
                        if (varAleatory2 % 2 != 0) { label6.ForeColor = Color.Red; }
                        else { label6.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void Random3()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory3 = rnd0.Next(36, 60);
                Thread.Sleep(20);
                switch (i)
                {
                    case 0:
                        Matriz1[2, 0] = Convert.ToString(varAleatory3);
                        if (varAleatory3 % 2 != 0) { label15.ForeColor = Color.Red; }
                        else { label15.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz1[2, 1] = Convert.ToString(varAleatory3);
                        if (varAleatory3 % 2 != 0) { label14.ForeColor = Color.Red; }
                        else { label14.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz1[2, 2] = Convert.ToString(varAleatory3);
                        if (varAleatory3 % 2 != 0) { label13.ForeColor = Color.Red; }
                        else { label13.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz1[2, 3] = Convert.ToString(varAleatory3);
                        if (varAleatory3 % 2 != 0) { label12.ForeColor = Color.Red; }
                        else { label12.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz1[2, 4] = Convert.ToString(varAleatory3);
                        if (varAleatory3 % 2 != 0) { label11.ForeColor = Color.Red; }
                        else { label11.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void Random4()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory4 = rnd0.Next(61, 100);
                Thread.Sleep(20);
                switch (i)
                {
                    case 0:
                        Matriz1[3, 0] = Convert.ToString(varAleatory4);
                        if (varAleatory4 % 2 != 0) { label20.ForeColor = Color.Red; }
                        else { label20.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz1[3, 1] = Convert.ToString(varAleatory4);
                        if (varAleatory4 % 2 != 0) { label19.ForeColor = Color.Red; }
                        else { label19.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz1[3, 2] = Convert.ToString(varAleatory4);
                        if (varAleatory4 % 2 != 0) { label18.ForeColor = Color.Red; }
                        else { label18.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz1[3, 3] = Convert.ToString(varAleatory4);
                        if (varAleatory4 % 2 != 0) { label17.ForeColor = Color.Red; }
                        else { label17.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz1[3, 4] = Convert.ToString(varAleatory4);
                        if (varAleatory4 % 2 != 0) { label16.ForeColor = Color.Red; }
                        else { label16.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void Random5()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory5 = rnd0.Next(101, 120);
                Thread.Sleep(20);

                switch (i)
                {
                    case 0:
                        Matriz1[4, 0] = Convert.ToString(varAleatory5);
                        if (varAleatory5 % 2 != 0) { label25.ForeColor = Color.Red; }
                        else { label25.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz1[4, 1] = Convert.ToString(varAleatory5);
                        if (varAleatory5 % 2 != 0) { label24.ForeColor = Color.Red; }
                        else { label24.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz1[4, 2] = Convert.ToString(varAleatory5);
                        if (varAleatory5 % 2 != 0) { label23.ForeColor = Color.Red; }
                        else { label23.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz1[4, 3] = Convert.ToString(varAleatory5);
                        if (varAleatory5 % 2 != 0) { label22.ForeColor = Color.Red; }
                        else { label22.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz1[4, 4] = Convert.ToString(varAleatory5);
                        if (varAleatory5 % 2 != 0) { label21.ForeColor = Color.Red; }
                        else { label21.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void LlamadoMatriz1()
        {
            //Fila 1

            label1.Text = "" + Matriz1[0, 0];
            label2.Text = "" + Matriz1[0, 1];
            label3.Text = "" + Matriz1[0, 2];
            label4.Text = "" + Matriz1[0, 3];
            label5.Text = "" + Matriz1[0, 4];

            //Fila 2
            label10.Text = "" + Matriz1[1, 0];
            label9.Text = "" + Matriz1[1, 1];
            label8.Text = "" + Matriz1[1, 2];
            label7.Text = "" + Matriz1[1, 3];
            label6.Text = "" + Matriz1[1, 4];

            //Fila 3
            label15.Text = "" + Matriz1[2, 0];
            label14.Text = "" + Matriz1[2, 1];
            label13.Text = "" + Matriz1[2, 2];
            label12.Text = "" + Matriz1[2, 3];
            label11.Text = "" + Matriz1[2, 4];

            //Fila 4
            label20.Text = "" + Matriz1[3, 0];
            label19.Text = "" + Matriz1[3, 1];
            label18.Text = "" + Matriz1[3, 2];
            label17.Text = "" + Matriz1[3, 3];
            label16.Text = "" + Matriz1[3, 4];

            //Fila 5
            label25.Text = "" + Matriz1[4, 0];
            label24.Text = "" + Matriz1[4, 1];
            label23.Text = "" + Matriz1[4, 2];
            label22.Text = "" + Matriz1[4, 3];
            label21.Text = "" + Matriz1[4, 4];
        }

        public void SumatoriaMatriz1()
        {
            bool flag = false;
            while (flag == false)
            {
                int fila1 = Convert.ToInt32(Matriz1[0, 0]) +
                            Convert.ToInt32(Matriz1[0, 1]) +
                            Convert.ToInt32(Matriz1[0, 2]) +
                            Convert.ToInt32(Matriz1[0, 3]) +
                            Convert.ToInt32(Matriz1[0, 4]);


                if (fila1 <= 55)
                {
                    flag = true;
                } else
                {
                    Random1();
                    flag = false;
                }
            }
        }

        public void SumatoriaMatriz2()
        {
            bool flag = false;
            while (flag == false)
            {
                int fila2 = Convert.ToInt32(Matriz1[1, 0]) +
                            Convert.ToInt32(Matriz1[1, 1]) +
                            Convert.ToInt32(Matriz1[1, 2]) +
                            Convert.ToInt32(Matriz1[1, 3]) +
                            Convert.ToInt32(Matriz1[1, 4]);
                if (fila2 <= 125)
                {
                    flag = true;
                }
                else
                {
                    Random2();
                    flag = false;
                }
            }
        }

        public void SumatoriaMatriz3()
        {
            bool flag = false;
            while (flag == false)
            {
               int fila3 = Convert.ToInt32(Matriz1[2, 0]) +
            Convert.ToInt32(Matriz1[2, 1]) +
            Convert.ToInt32(Matriz1[2, 2]) +
            Convert.ToInt32(Matriz1[2, 3]) +
            Convert.ToInt32(Matriz1[2, 4]);
                if (fila3 <= 190)
                {
                    flag = true;
                }
                else
                {
                    Random3();
                    flag = false;
                }
            }
        }

        public void SumatoriaMatriz4()
        {
            bool flag = false;
            while (flag == false)
            {
                int fila4 = Convert.ToInt32(Matriz1[3, 0]) +
                            Convert.ToInt32(Matriz1[3, 1]) +
                            Convert.ToInt32(Matriz1[3, 2]) +
                            Convert.ToInt32(Matriz1[3, 3]) +
                            Convert.ToInt32(Matriz1[3, 4]);
                if (fila4 <= 400)
                {
                    flag = true;
                }
                else
                {
                    Random4();
                    flag = false;
                }
            }
        }

        public void SumatoriaMatriz5()
        {
            bool flag = false;
            while (flag == false)
            {
                int fila5 = Convert.ToInt32(Matriz1[4, 0]) +
                            Convert.ToInt32(Matriz1[4, 1]) +
                            Convert.ToInt32(Matriz1[4, 2]) +
                            Convert.ToInt32(Matriz1[4, 3]) +
                            Convert.ToInt32(Matriz1[4, 4]);

                if (fila5 <= 600)
                {
                    flag = true;
                }
                else
                {
                    Random5();
                    flag = false;
                }
            }
        }

        // Matriz 2

        public void Random6()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory6 = rnd0.Next(100, 200);
                Thread.Sleep(20);
                switch (i)
                {
                    case 0:
                        Matriz2[0, 0] = Convert.ToString(varAleatory6);
                        if (varAleatory6 % 2 != 0) { label50.ForeColor = Color.Red; }
                        else { label50.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz2[0, 1] = Convert.ToString(varAleatory6);
                        if (varAleatory6 % 2 != 0) { label49.ForeColor = Color.Red; }
                        else { label49.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz2[0, 2] = Convert.ToString(varAleatory6);
                        if (varAleatory6 % 2 != 0) { label48.ForeColor = Color.Red; }
                        else { label48.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz2[0, 3] = Convert.ToString(varAleatory6);
                        if (varAleatory6 % 2 != 0) { label47.ForeColor = Color.Red; }
                        else { label47.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz2[0, 4] = Convert.ToString(varAleatory6);
                        if (varAleatory6 % 2 != 0) { label46.ForeColor = Color.Red; }
                        else { label46.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void Random7()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory7 = rnd0.Next(19, 39);
                Thread.Sleep(20);
                switch (i)
                {
                    case 0:
                        Matriz2[1, 0] = Convert.ToString(varAleatory7);
                        if (varAleatory7 % 2 != 0) { label10.ForeColor = Color.Red; }
                        else { label45.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz2[1, 1] = Convert.ToString(varAleatory7);
                        if (varAleatory7 % 2 != 0) { label9.ForeColor = Color.Red; }
                        else { label44.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz2[1, 2] = Convert.ToString(varAleatory7);
                        if (varAleatory7 % 2 != 0) { label8.ForeColor = Color.Red; }
                        else { label43.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz2[1, 3] = Convert.ToString(varAleatory7);
                        if (varAleatory7 % 2 != 0) { label7.ForeColor = Color.Red; }
                        else { label42.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz2[1, 4] = Convert.ToString(varAleatory7);
                        if (varAleatory7 % 2 != 0) { label6.ForeColor = Color.Red; }
                        else { label41.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void Random8()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory8 = rnd0.Next(90, 110);
                Thread.Sleep(20);
                switch (i)
                {
                    case 0:
                        Matriz2[2, 0] = Convert.ToString(varAleatory8);
                        if (varAleatory8 % 2 != 0) { label40.ForeColor = Color.Red; }
                        else { label40.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz2[2, 1] = Convert.ToString(varAleatory8);
                        if (varAleatory8 % 2 != 0) { label39.ForeColor = Color.Red; }
                        else { label39.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz2[2, 2] = Convert.ToString(varAleatory8);
                        if (varAleatory8 % 2 != 0) { label38.ForeColor = Color.Red; }
                        else { label38.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz2[2, 3] = Convert.ToString(varAleatory8);
                        if (varAleatory8 % 2 != 0) { label37.ForeColor = Color.Red; }
                        else { label37.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz2[2, 4] = Convert.ToString(varAleatory8);
                        if (varAleatory8 % 2 != 0) { label36.ForeColor = Color.Red; }
                        else { label36.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void Random9()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory9 = rnd0.Next(18, 96);
                Thread.Sleep(20);
                switch (i)
                {
                    case 0:
                        Matriz2[3, 0] = Convert.ToString(varAleatory9);
                        if (varAleatory9 % 2 != 0) { label35.ForeColor = Color.Red; }
                        else { label35.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz2[3, 1] = Convert.ToString(varAleatory9);
                        if (varAleatory9 % 2 != 0) { label34.ForeColor = Color.Red; }
                        else { label34.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz2[3, 2] = Convert.ToString(varAleatory9);
                        if (varAleatory9 % 2 != 0) { label33.ForeColor = Color.Red; }
                        else { label33.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz2[3, 3] = Convert.ToString(varAleatory9);
                        if (varAleatory9 % 2 != 0) { label32.ForeColor = Color.Red; }
                        else { label32.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz2[3, 4] = Convert.ToString(varAleatory9);
                        if (varAleatory9 % 2 != 0) { label31.ForeColor = Color.Red; }
                        else { label31.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void Random10()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Random rnd0 = new Random();
                varAleatory0 = rnd0.Next(150, 190);
                Thread.Sleep(20);

                switch (i)
                {
                    case 0:
                        Matriz2[4, 0] = Convert.ToString(varAleatory0);
                        if (varAleatory0 % 2 != 0) { label30.ForeColor = Color.Red; }
                        else { label30.ForeColor = Color.Black; }
                        break;

                    case 1:
                        Matriz2[4, 1] = Convert.ToString(varAleatory0);
                        if (varAleatory0 % 2 != 0) { label29.ForeColor = Color.Red; }
                        else { label29.ForeColor = Color.Black; }
                        break;

                    case 2:
                        Matriz2[4, 2] = Convert.ToString(varAleatory0);
                        if (varAleatory0 % 2 != 0) { label28.ForeColor = Color.Red; }
                        else { label28.ForeColor = Color.Black; }
                        break;

                    case 3:
                        Matriz2[4, 3] = Convert.ToString(varAleatory0);
                        if (varAleatory0 % 2 != 0) { label27.ForeColor = Color.Red; }
                        else { label27.ForeColor = Color.Black; }
                        break;
                    case 4:
                        Matriz2[4, 4] = Convert.ToString(varAleatory0);
                        if (varAleatory0 % 2 != 0) { label26.ForeColor = Color.Red; }
                        else { label26.ForeColor = Color.Black; }
                        break;

                }
            }
        }

        public void LlamadoMatriz2()
        {
            //Fila 1

            label50.Text = "" + Matriz2[0, 0];
            label49.Text = "" + Matriz2[0, 1];
            label48.Text = "" + Matriz2[0, 2];
            label47.Text = "" + Matriz2[0, 3];
            label46.Text = "" + Matriz2[0, 4];

            //Fila 2
            label45.Text = "" + Matriz2[1, 0];
            label44.Text = "" + Matriz2[1, 1];
            label43.Text = "" + Matriz2[1, 2];
            label42.Text = "" + Matriz2[1, 3];
            label41.Text = "" + Matriz2[1, 4];

            //Fila 3
            label40.Text = "" + Matriz2[2, 0];
            label39.Text = "" + Matriz2[2, 1];
            label38.Text = "" + Matriz2[2, 2];
            label37.Text = "" + Matriz2[2, 3];
            label36.Text = "" + Matriz2[2, 4];

            //Fila 4
            label35.Text = "" + Matriz2[3, 0];
            label34.Text = "" + Matriz2[3, 1];
            label33.Text = "" + Matriz2[3, 2];
            label32.Text = "" + Matriz2[3, 3];
            label31.Text = "" + Matriz2[3, 4];

            //Fila 5
            label30.Text = "" + Matriz2[4, 0];
            label29.Text = "" + Matriz2[4, 1];
            label28.Text = "" + Matriz2[4, 2];
            label27.Text = "" + Matriz2[4, 3];
            label26.Text = "" + Matriz2[4, 4];
        }

        // Matriz 3
        public void LlamadoMatriz3()
        {
            //Fila 1

            label75.Text = Convert.ToString(Convert.ToInt32(Matriz1[0, 0]) - Convert.ToInt32(Matriz2[0, 0]));
            label74.Text = Convert.ToString(Convert.ToInt32(Matriz1[0, 1]) - Convert.ToInt32(Matriz2[0, 1]));
            label73.Text = Convert.ToString(Convert.ToInt32(Matriz1[0, 2]) - Convert.ToInt32(Matriz2[0, 2]));
            label72.Text = Convert.ToString(Convert.ToInt32(Matriz1[0, 3]) - Convert.ToInt32(Matriz2[0, 3]));
            label71.Text = Convert.ToString(Convert.ToInt32(Matriz1[0, 4]) - Convert.ToInt32(Matriz2[0, 4]));

            //Fila 2
            label70.Text = Convert.ToString(Convert.ToInt32(Matriz1[1, 0]) - Convert.ToInt32(Matriz2[1, 0]));
            label69.Text = Convert.ToString(Convert.ToInt32(Matriz1[1, 1]) - Convert.ToInt32(Matriz2[1, 1]));
            label68.Text = Convert.ToString(Convert.ToInt32(Matriz1[1, 2]) - Convert.ToInt32(Matriz2[1, 2]));
            label67.Text = Convert.ToString(Convert.ToInt32(Matriz1[1, 3]) - Convert.ToInt32(Matriz2[1, 3]));
            label66.Text = Convert.ToString(Convert.ToInt32(Matriz1[1, 4]) - Convert.ToInt32(Matriz2[1, 4]));

            //Fila 3
            label65.Text = Convert.ToString(Convert.ToInt32(Matriz1[2, 0]) - Convert.ToInt32(Matriz2[2, 0]));
            label64.Text = Convert.ToString(Convert.ToInt32(Matriz1[2, 1]) - Convert.ToInt32(Matriz2[2, 1]));
            label63.Text = Convert.ToString(Convert.ToInt32(Matriz1[2, 2]) - Convert.ToInt32(Matriz2[2, 2]));
            label62.Text = Convert.ToString(Convert.ToInt32(Matriz1[2, 3]) - Convert.ToInt32(Matriz2[2, 3]));
            label61.Text = Convert.ToString(Convert.ToInt32(Matriz1[2, 4]) - Convert.ToInt32(Matriz2[2, 4]));

            //Fila 4
            label60.Text = Convert.ToString(Convert.ToInt32(Matriz1[3, 0]) - Convert.ToInt32(Matriz2[3, 0]));
            label59.Text = Convert.ToString(Convert.ToInt32(Matriz1[3, 1]) - Convert.ToInt32(Matriz2[3, 1]));
            label58.Text = Convert.ToString(Convert.ToInt32(Matriz1[3, 2]) - Convert.ToInt32(Matriz2[3, 2]));
            label57.Text = Convert.ToString(Convert.ToInt32(Matriz1[3, 3]) - Convert.ToInt32(Matriz2[3, 3]));
            label56.Text = Convert.ToString(Convert.ToInt32(Matriz1[3, 4]) - Convert.ToInt32(Matriz2[3, 4]));

            //Fila 5
            label55.Text = Convert.ToString(Convert.ToInt32(Matriz1[4, 0]) - Convert.ToInt32(Matriz2[4, 0]));
            label54.Text = Convert.ToString(Convert.ToInt32(Matriz1[4, 1]) - Convert.ToInt32(Matriz2[4, 1]));
            label53.Text = Convert.ToString(Convert.ToInt32(Matriz1[4, 2]) - Convert.ToInt32(Matriz2[4, 2]));
            label52.Text = Convert.ToString(Convert.ToInt32(Matriz1[4, 3]) - Convert.ToInt32(Matriz2[4, 3]));
            label51.Text = Convert.ToString(Convert.ToInt32(Matriz1[4, 4]) - Convert.ToInt32(Matriz2[4, 4]));
        }

        //public void colorearMatriz3F1()
        //{
        //    for (int f1 = 0; f1 < tamanho;  f1++)
        //    {
        //        switch (f1)
        //        {
        //            case 0:
        //                if (Convert.ToInt32(label75.Text) % 2 != 0) { label75.ForeColor = Color.Red; }
        //                else { label75.ForeColor = Color.Black; }
        //                break;

        //            case 1:
        //                if (Convert.ToInt32(label74.Text) % 2 != 0) { label74.ForeColor = Color.Red; }
        //                else { label74.ForeColor = Color.Black; }
        //                break;

        //            case 2:
        //                if (Convert.ToInt32(label73.Text) % 2 != 0) { label73.ForeColor = Color.Red; }
        //                else { label73.ForeColor = Color.Black; }
        //                break;

        //            case 3:
        //                if (Convert.ToInt32(label72.Text) % 2 != 0) { label72.ForeColor = Color.Red; }
        //                else { label72.ForeColor = Color.Black; }
        //                break;
        //            case 4:
        //                if (Convert.ToInt32(label71.Text) % 2 != 0) { label71.ForeColor = Color.Red; }
        //                else { label71.ForeColor = Color.Black; }
        //                break;

        //        }
        //    }
        //}

        //public void colorearMatriz3F2()
        //{
        //    for (int f1 = 0; f1 < tamanho; f1++)
        //    {
        //        switch (f1)
        //        {
        //            case 0:
        //                if (Convert.ToInt32(label70.Text) % 2 != 0) { label70.ForeColor = Color.Red; }
        //                else { label70.ForeColor = Color.Black; }
        //                break;

        //            case 1:
        //                if (Convert.ToInt32(label69.Text) % 2 != 0) { label69.ForeColor = Color.Red; }
        //                else { label69.ForeColor = Color.Black; }
        //                break;

        //            case 2:
        //                if (Convert.ToInt32(label68.Text) % 2 != 0) { label68.ForeColor = Color.Red; }
        //                else { label68.ForeColor = Color.Black; }
        //                break;

        //            case 3:
        //                if (Convert.ToInt32(label67.Text) % 2 != 0) { label67.ForeColor = Color.Red; }
        //                else { label67.ForeColor = Color.Black; }
        //                break;
        //            case 4:
        //                if (Convert.ToInt32(label66.Text) % 2 != 0) { label66.ForeColor = Color.Red; }
        //                else { label66.ForeColor = Color.Black; }
        //                break;

        //        }
        //    }
        //}

        //public void colorearMatriz3F3()
        //{
        //    for (int f1 = 0; f1 < tamanho; f1++)
        //    {
        //        switch (f1)
        //        {
        //            case 0:
        //                if (Convert.ToInt32(label65.Text) % 2 != 0) { label65.ForeColor = Color.Red; }
        //                else { label65.ForeColor = Color.Black; }
        //                break;

        //            case 1:
        //                if (Convert.ToInt32(label64.Text) % 2 != 0) { label64.ForeColor = Color.Red; }
        //                else { label64.ForeColor = Color.Black; }
        //                break;

        //            case 2:
        //                if (Convert.ToInt32(label63.Text) % 2 != 0) { label63.ForeColor = Color.Red; }
        //                else { label63.ForeColor = Color.Black; }
        //                break;

        //            case 3:
        //                if (Convert.ToInt32(label62.Text) % 2 != 0) { label62.ForeColor = Color.Red; }
        //                else { label62.ForeColor = Color.Black; }
        //                break;
        //            case 4:
        //                if (Convert.ToInt32(label61.Text) % 2 != 0) { label61.ForeColor = Color.Red; }
        //                else { label61.ForeColor = Color.Black; }
        //                break;

        //        }
        //    }
        //}

        //public void colorearMatriz3F4()
        //{
        //    for (int f1 = 0; f1 < tamanho; f1++)
        //    {
        //        switch (f1)
        //        {
        //            case 0:
        //                if (Convert.ToInt32(label60.Text) % 2 != 0) { label60.ForeColor = Color.Red; }
        //                else { label60.ForeColor = Color.Black; }
        //                break;

        //            case 1:
        //                if (Convert.ToInt32(label59.Text) % 2 != 0) { label59.ForeColor = Color.Red; }
        //                else { label59.ForeColor = Color.Black; }
        //                break;

        //            case 2:
        //                if (Convert.ToInt32(label58.Text) % 2 != 0) { label58.ForeColor = Color.Red; }
        //                else { label58.ForeColor = Color.Black; }
        //                break;

        //            case 3:
        //                if (Convert.ToInt32(label57.Text) % 2 != 0) { label57.ForeColor = Color.Red; }
        //                else { label57.ForeColor = Color.Black; }
        //                break;
        //            case 4:
        //                if (Convert.ToInt32(label56.Text) % 2 != 0) { label56.ForeColor = Color.Red; }
        //                else { label56.ForeColor = Color.Black; }
        //                break;

        //        }
        //    }
        //}

        //public void colorearMatriz3F5()
        //{
        //    for (int f1 = 0; f1 < tamanho; f1++)
        //    {
        //        switch (f1)
        //        {
        //            case 0:
        //                if (Convert.ToInt32(label55.Text) % 2 != 0) { label55.ForeColor = Color.Red; }
        //                else { label55.ForeColor = Color.Black; }
        //                break;

        //            case 1:
        //                if (Convert.ToInt32(label54.Text) % 2 != 0) { label54.ForeColor = Color.Red; }
        //                else { label54.ForeColor = Color.Black; }
        //                break;

        //            case 2:
        //                if (Convert.ToInt32(label53.Text) % 2 != 0) { label53.ForeColor = Color.Red; }
        //                else { label53.ForeColor = Color.Black; }
        //                break;

        //            case 3:
        //                if (Convert.ToInt32(label52.Text) % 2 != 0) { label52.ForeColor = Color.Red; }
        //                else { label52.ForeColor = Color.Black; }
        //                break;
        //            case 4:
        //                if (Convert.ToInt32(label51.Text) % 2 != 0) { label51.ForeColor = Color.Red; }
        //                else { label51.ForeColor = Color.Black; }
        //                break;

        //        }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Random1();
            Random2();
            Random3();
            Random4();
            Random5();

            //SumatoriaMatriz1();
            //SumatoriaMatriz2();
            //SumatoriaMatriz3();
            //SumatoriaMatriz4();
            //SumatoriaMatriz5();
            LlamadoMatriz1();

            Random6();
            Random7();
            Random8();
            Random9();
            Random10();
            LlamadoMatriz2();

            //colorearMatriz3F1();
            //colorearMatriz3F2();
            //colorearMatriz3F3();
            //colorearMatriz3F4();
            //colorearMatriz3F5();
            LlamadoMatriz3();
        }
    }
}
