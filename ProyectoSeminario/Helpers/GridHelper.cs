using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Windows.Helpers
{
    public static class GridHelper
    {
        //public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        //{
        //    LimpiarGrilla(dgv);
        //    foreach (var item in lista)
        //    {
        //        var r = ConstruirFila(dgv);
        //        SetearFila(r, item);
        //        AgregarFila(r, dgv);
        //    }
        //}
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case ProductoListDto producto:
                    r.Cells[0].Value = producto.Nombre;
                    r.Cells[1].Value = producto.NombreCategoria;
                    r.Cells[2].Value = producto.PrecioVenta.ToString();
                    r.Cells[3].Value = producto.Activo.ToString();
                    break;
                case CategoriaListDto categoria:
                    r.Cells[0].Value = categoria.NombreCategoria;
                    r.Cells[1].Value = categoria.Activa.ToString();
                    break;
            }
            r.Tag = obj;
        }
        public static void AgregarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Add(r);
        }

        public static void QuitarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Remove(r);
        }
    }
}
