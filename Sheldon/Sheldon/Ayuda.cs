using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sheldon
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
            helpgrid.Columns.Add("caracteristica","Catacteristica");
            helpgrid.Columns.Add("description","Descripcion");
            helpgrid.Columns[0].Width = 140;
            helpgrid.Columns[1].Width = 280;
            helpgrid.Rows.Add("Manejar Conexiones","Posiblilidad de conectarse con varias victimas y tener el control de cada una");
            helpgrid.Rows.Add("Monitoreo", "Monitorear constantemente diferentes caracteristicas de la pc de la victima.");
            helpgrid.Rows.Add("Mataprocesos", "Manejar remotamente los procesos que esta ejecutando la victima.");
            helpgrid.Rows.Add("Listar Bibliotecas", "Adentrarse en los datos(documentos, imagenes) de la victima y descargarlos.");
            helpgrid.Rows.Add("Recibir Mails", "Recibir Informacion(archivos, reportes) de la victima via correo");
        }
    }
}
