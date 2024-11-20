using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // Recopilar datos
            string nie = txtNIE.Text;
            string passport = txtPassport.Text;
            string firstName = txtFirstName.Text;
            string lastName1 = txtLastName1.Text;
            string lastName2 = txtLastName2.Text;
            string parentsNames = txtParentsNames.Text;
            string maritalStatus = cmbMaritalStatus.SelectedItem?.ToString();
            string address = txtAddress.Text;
            string gender = cmbGender.SelectedItem?.ToString();
            string destination = txtDestination.Text;
            string travelCompanions = txtCompanions.Text;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(nie) || string.IsNullOrWhiteSpace(passport) ||
                string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName1))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar datos recopilados
            MessageBox.Show($"Datos del Formulario:\n\n" +
                            $"NIE: {nie}\nPasaporte: {passport}\nNombre: {firstName}\nApellido 1: {lastName1}\n" +
                            $"Apellido 2: {lastName2}\nPadres: {parentsNames}\nEstado Civil: {maritalStatus}\n" +
                            $"Domicilio: {address}\nSexo: {gender}\n\n" +
                            $"Destino: {destination}\nViaja con: {travelCompanions}",
                            "Formulario Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
