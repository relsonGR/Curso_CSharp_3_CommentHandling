using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_CSharp_3_CommentHandling
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        //Esto es un comentario de una sola linea

        /* Aqui comienza el comentario
         * 
         * 
         * 
         * 
         * 
         * Aqui termina comentario
         */


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();   //ejemplo esta linea es importante XD
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //Ejecuta el form principal
        }
    }
}
