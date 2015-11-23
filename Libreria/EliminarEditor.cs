﻿using Libreria.DBclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Libreria
{
    public partial class EliminarEditor : PantallaInicial
    {
        public EliminarEditor()
        {
            InitializeComponent();
        }

        private void EliminarEditor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                PrincipalFP db = new PrincipalFP();
                int idEditores = int.Parse(textBox1.Text);
                var emp = db.Editores
                          .SingleOrDefault(x => x.idEditores == idEditores);
                // where x.id == id
                //select x;

                if (emp != null)
                {
                    db.Editores.Remove(emp);
                    MessageBox.Show("Eliminar exito.");
                    db.SaveChanges();
                    textBox1.Clear();
                }
            }

            else
            {
                MessageBox.Show("Solo numeros #id");

            }
        }
    }
}
