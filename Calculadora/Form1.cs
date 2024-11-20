using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repasoExamen1
{
    public partial class Form1 : Form
    {
        string clearedText;  // Variable para almacenar el texto antes de borrar.
        string clearedResult;  // Variable para almacenar el resultado antes de borrar.

        public Form1()
        {
            InitializeComponent();  // Inicializa los componentes del formulario.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se carga el formulario.
        }

        // Método para manejar los clics en los botones de números y operadores.
        private void numbers_operators_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;  // Obtiene el botón que fue presionado.
            operationLabel.Text += clickedButton.Text;  // Agrega el texto del botón al campo de operaciones.
        }

        // Método para manejar el clic en el botón de la coma.
        private void comma_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;  // Obtiene el botón de coma.

            if (clickedButton != null)
            {
                // Divide el texto de la operación por los operadores para obtener el número actual.
                string[] parts = Regex.Split(operationLabel.Text, @"[+\-x÷]");

                string currentNumber = parts.Length > 0 ? parts[parts.Length - 1].Trim() : "";

                // Si el número actual no contiene una coma, se agrega.
                if (!currentNumber.Contains(","))
                {
                    operationLabel.Text += clickedButton.Text;  // Agrega la coma.
                }
            }
        }

        // Método para limpiar la operación y el resultado.
        private void clear_all(object sender, EventArgs e)
        {
            clearedText = operationLabel.Text;  // Guarda el texto actual antes de limpiar.
            clearedResult = resultLabel.Text;  // Guarda el resultado actual antes de limpiar.
            operationLabel.Text = "";  // Limpia la operación.
            resultLabel.Text = "";  // Limpia el resultado.
        }

        // Método para deshacer la última acción y restaurar el texto original.
        private void undo(object sender, EventArgs e)
        {
            operationLabel.Text = clearedText;  // Restaura el texto de la operación anterior.
        }

        // Método para calcular el resultado de la operación.
        private void get_result(object sender, EventArgs e)
        {
            try
            {
                string expression = operationLabel.Text
                    .Replace("x", "*")  // Reemplaza 'x' por '*' para la multiplicación.
                    .Replace(",", ".");  // Reemplaza la coma por punto para decimales.

                // Evalúa la expresión matemática usando DataTable.Compute.
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");

                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                // Si hay un error en la expresión, muestra un mensaje de error.
                MessageBox.Show($"Invalid expression: {ex.Message}");
            }
        }

        // Método para obtener el módulo (parte decimal) de un número.
        private void get_module(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = number % 1;  // Obtiene el resto de la división por 1 (parte decimal).
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular el factorial de un número.
        private void get_factorial(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(operationLabel.Text);  // Convierte el texto a entero.
            int result = 1;

            // Calcula el factorial del número.
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            resultLabel.Text = result.ToString();  // Muestra el resultado del factorial.
        }

        // Método para calcular el valor exponencial (e^x) de un número.
        private void get_exp(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Exp(number);  // Calcula la exponencial (e^x).
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular el valor absoluto de un número.
        private void get_absolute_value(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Abs(number);  // Calcula el valor absoluto.
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para obtener la parte fraccionaria de un número.
        private void get_fraction(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double fractionalPart = number - Math.Floor(number);  // Calcula la parte decimal.
            resultLabel.Text = fractionalPart.ToString();  // Muestra la parte decimal.
        }

        // Método para mostrar el valor de Pi.
        private void add_pi(object sender, EventArgs e)
        {
            double result = Math.PI;  // Obtiene el valor de Pi.
            resultLabel.Text = result.ToString();  // Muestra Pi.
        }

        // Método para calcular el cuadrado de un número.
        private void get_sqr(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Pow(number, 2);  // Calcula el cuadrado.
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular la raíz cuadrada de un número.
        private void get_sqr_root(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            if (number >= 0)
            {
                double result = Math.Sqrt(number);  // Calcula la raíz cuadrada.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            else
            {
                resultLabel.Text = "Error: Negative input";  // Si el número es negativo, muestra un error.
            }
        }

        // Método para calcular el logaritmo en base 10 de un número.
        private void get_log(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            if (number > 0)
            {
                double result = Math.Log10(number);  // Calcula el logaritmo en base 10.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            else
            {
                resultLabel.Text = "Error: Input must be greater than 0";  // Muestra un error si el número es 0 o negativo.
            }
        }

        // Método para calcular el logaritmo natural (base e) de un número.
        private void get_ln(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            if (number > 0)
            {
                double result = Math.Log(number);  // Calcula el logaritmo natural.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            else
            {
                resultLabel.Text = "Error: Input must be greater than 0";  // Muestra un error si el número es 0 o negativo.
            }
        }

        // Método para calcular el seno hiperbólico de un número.
        private void btnSinh_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Sinh(number);  // Calcula el seno hiperbólico.
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular el coseno hiperbólico de un número.
        private void btnCosh_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Cosh(number);  // Calcula el coseno hiperbólico.
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular la tangente hiperbólica de un número.
        private void btnTanh_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Tanh(number);  // Calcula la tangente hiperbólica.
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular el seno de un número (en radianes).
        private void btnSin_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Sin(number);  // Calcula el seno (en radianes).
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular el coseno de un número (en radianes).
        private void btnCos_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Cos(number);  // Calcula el coseno (en radianes).
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular la tangente de un número (en radianes).
        private void btnTan_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = Math.Tan(number);  // Calcula la tangente (en radianes).
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular la cotangente de un número (1/tan(x)).
        private void btnCot_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = 1 / Math.Tan(number);  // Calcula la cotangente.
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular la secante de un número (1/cos(x)).
        private void btnSec_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = 1 / Math.Cos(number);  // Calcula la secante.
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para calcular la cosecante de un número (1/sin(x)).
        private void btnCsc_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
            double result = 1 / Math.Sin(number);  // Calcula la cosecante.
            resultLabel.Text = result.ToString();  // Muestra el resultado.
        }

        // Método para mostrar el valor de euler (constante e).
        private void btnE_Click(object sender, EventArgs e)
        {
            double result = Math.E;  // Obtiene el valor de euler (e).
            resultLabel.Text = result.ToString();  // Muestra e.
        }
    }
}

