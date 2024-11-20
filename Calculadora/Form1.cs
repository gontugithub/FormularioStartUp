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

        private void numbers_operators_click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;  // Obtiene el botón que fue presionado.
                operationLabel.Text += clickedButton.Text;  // Agrega el texto del botón al campo de operaciones.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in numbers_operators_click: {ex.Message}");
            }
        }

        private void comma_click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error in comma_click: {ex.Message}");
            }
        }

        private void clear_all(object sender, EventArgs e)
        {
            try
            {
                clearedText = operationLabel.Text;  // Guarda el texto actual antes de limpiar.
                clearedResult = resultLabel.Text;  // Guarda el resultado actual antes de limpiar.
                operationLabel.Text = "";  // Limpia la operación.
                resultLabel.Text = "";  // Limpia el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in clear_all: {ex.Message}");
            }
        }

        private void undo(object sender, EventArgs e)
        {
            try
            {
                operationLabel.Text = clearedText;  // Restaura el texto de la operación anterior.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in undo: {ex.Message}");
            }
        }

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
                MessageBox.Show($"Error in get_result: {ex.Message}");
            }
        }

        private void get_module(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = number % 1;  // Obtiene el resto de la división por 1 (parte decimal).
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_module: {ex.Message}");
            }
        }

        private void get_factorial(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_factorial: {ex.Message}");
            }
        }

        private void get_exp(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Exp(number);  // Calcula la exponencial (e^x).
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_exp: {ex.Message}");
            }
        }

        private void get_absolute_value(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Abs(number);  // Calcula el valor absoluto.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_absolute_value: {ex.Message}");
            }
        }

        private void get_fraction(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double fractionalPart = number - Math.Floor(number);  // Calcula la parte decimal.
                resultLabel.Text = fractionalPart.ToString();  // Muestra la parte decimal.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_fraction: {ex.Message}");
            }
        }

        private void add_pi(object sender, EventArgs e)
        {
            try
            {
                double result = Math.PI;  // Obtiene el valor de Pi.
                resultLabel.Text = result.ToString();  // Muestra Pi.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in add_pi: {ex.Message}");
            }
        }

        private void get_sqr(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Pow(number, 2);  // Calcula el cuadrado.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_sqr: {ex.Message}");
            }
        }

        private void get_sqr_root(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_sqr_root: {ex.Message}");
            }
        }

        private void get_log(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_log: {ex.Message}");
            }
        }

        private void get_ln(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error in get_ln: {ex.Message}");
            }
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Sinh(number);  // Calcula el seno hiperbólico.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnSinh_Click: {ex.Message}");
            }
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Cosh(number);  // Calcula el coseno hiperbólico.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnCosh_Click: {ex.Message}");
            }
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Tanh(number);  // Calcula la tangente hiperbólica.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnTanh_Click: {ex.Message}");
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Sin(number);  // Calcula el seno (en radianes).
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnSin_Click: {ex.Message}");
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Cos(number);  // Calcula el coseno (en radianes).
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnCos_Click: {ex.Message}");
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = Math.Tan(number);  // Calcula la tangente (en radianes).
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnTan_Click: {ex.Message}");
            }
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = 1 / Math.Tan(number);  // Calcula la cotangente.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnCot_Click: {ex.Message}");
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = 1 / Math.Cos(number);  // Calcula la secante.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnSec_Click: {ex.Message}");
            }
        }

        private void btnCsc_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(operationLabel.Text);  // Convierte el texto a número.
                double result = 1 / Math.Sin(number);  // Calcula la cosecante.
                resultLabel.Text = result.ToString();  // Muestra el resultado.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnCsc_Click: {ex.Message}");
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Math.E;  // Obtiene el valor de euler (e).
                resultLabel.Text = result.ToString();  // Muestra e.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnE_Click: {ex.Message}");
            }
        }

        private void operationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
