using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoV2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }

        //DECLARANDO VARIABLES
        int n = 0;
        int progress;

        double[] x; //DECLARANDO ARRAY
        

        //INICIALIZANDO EL CICLO
        int i = 0;

        //METODO PARA AGREGAR N
        private void btnArray_Click(object sender, EventArgs e)
        {
           
            i = 0;
            n = Convert.ToInt32(txtN.Text); //DARLE VALOR A "N"
            

            if (n==0 || txtN.Text ==null)
            {
                errorIcono.SetError(txtN, "Ingrese N"); //CREANDO ERROR
            }
            else {
                    x = new double[n]; // ARRAY VA HASTA N
                    errorIcono.Clear(); //LIMPIANDO EL ERROR
                    txtX.Enabled = true; //ACTIVANDO TextBox CAMPO X
                    btnAgregarX.Enabled = true; //ACTIVANDO TextBox CAMPO X
                    lblResu.Text = ""; //LIMPIANDO EL CAMPO DEL RESULTADO
                    lstX.Items.Clear(); //LIMPIANDO DATOS LISTA DEL ARRAY(X)
                    txtN.Enabled = false; //DESACTIVANDO TextBox CAMPO N
                    btnArray.Enabled = false; //DESACTIVANDO Button CAMPO N(Longitud del Array)
                    btnCalcular.Enabled = true; //ACTIVANDO Button CALCULAR(Operaciones)


                if (n<5)
                {
                    progreso.Visible = true;  //MOSTRANDO EL PROGRESO
                    progreso.Value = 0;
                    progress = 50;
                    progreso.Value = progress;  //AUMENTA EL PROGRESO A 50
               
                }
                else
                {
                    progreso.Visible = true;  //MOSTRANDO EL PROGRESO
                    progreso.Value = 0;
                    progress = 20;
                    progreso.Value = progress; //AUMENTA EL PROGRESO A 20
                }
                 
            }

        }
       
        //METODO PARA AGREGAR LAS Xs
        private void btnAgregarX_Click(object sender, EventArgs e)
        {

            if (i < n)
            {
                x[i] = Convert.ToDouble(txtX.Text); //LLEVANDO DATOS DEL TextBox "X", a "X" en la posición "i"
                lstX.Items.Add(x[i]); //AGREGANDO DATOS LISTA DEL ARRAY(X)
               

                i++;
                txtX.Clear(); //LIMPIANDO TextBox X               

                    progress = progress + 10;
                    progreso.Value = progress; // AUMENTANDO EL PREGRESO DE A 10

            }
            else {
                lblResu.Text = "Ya ingresó todos los datos."; //MENSAJE DE ERROR EN Label "Resultado"(lblResu)
                btnAgregarX.Enabled = false; //DESACTIVANDO Button CAMPO X( AGREGAR Xs(equis) )
                txtX.BackColor = Color.Red; //CAMBIO DE COLOR TextBox X
                imgFlecha.Visible = true; //ACTIVANDO IMAGEN FLECHA, SEÑALA EL BOTÓN CALCULAR
            }
       
        }

        //METODO OPERACIONES(SUMATORIA, PROMEDIO, SUCESIÓN, VARIANZA)

        private void button1_Click(object sender, EventArgs e)
        {

                double suma = 0, promedio, sumatoria = 0, varianza = 0;

            //SUMATORIA o ACUMULADOR PARA LAS Xs
                for (int i = 0; i < n; i++)
                {
                    suma = suma + x[i];
                }

            //PROMEDIO
                promedio = suma / n;

            //SUCESIÓN
                for (int i = 0; i < n; i++)
                {
                    sumatoria = sumatoria + Math.Pow((x[i] - promedio), 2);
                }
            //VARIANZA
                varianza = sumatoria / n;

                lblResu.Text = varianza.ToString(); //MOSTRANDO EL RESULTADO DE LA VARIANZA EN UN LABEL
                lstVarianza.Items.Add(varianza); //AGREGANDO LOS RESULTADOS DE LAS VARIANZAS EN UNA LISTA

                txtX.Enabled = false; //DESACTIVANDO TextBox CAMPO X
                btnAgregarX.Enabled = false; //DESACTIVANDO Button CAMPO X( AGREGAR Xs(equis) )
                txtN.Enabled = true;  //ACTIVANDO TextBox CAMPO N
                btnArray.Enabled = true;  //ACTIVANDO Button CAMPO N(Longitud del Array)
                txtX.Clear(); //LIMPIANDO TextBox X
                x = new double[0]; //LIMPIANDO LONGITUD DEL ARRAY
                btnCalcular.Enabled = false; //DESACTIVANDO Button CALCULAR(Operaciones)
                txtX.BackColor = Color.White; //CAMBIO DE COLOR TextBox X
                imgFlecha.Visible = false; //DESACTIVANDO IMAGEN FLECHA, SEÑALA EL BOTÓN CALCULAR

                progreso.Value = 100; //AUMENTO EL PROGRESO AL MAXIMO

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //METODO DEFINICION DE VARIANZA

        private void label1_Click(object sender, EventArgs e)
        {
            //INSTANCIANDO LA CLASE definicionVarianza, ES DECIR CREANDO UN OBJETO DE LA CLASE(objDefinicionV).
            definicionVarianza objDefinicionV = new definicionVarianza();

            //MOSTRANDO CUADRO DE INFORMACIÓN 
            objDefinicionV.ShowDialog();


        }
    }
}
