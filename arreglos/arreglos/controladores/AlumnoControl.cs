using arreglos.entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos.controladores
{
    internal class AlumnoControl
    {
        //Arreglo
        private Alumno[] alumnos = new Alumno[100];
        private int cont = 0;

        // Listar todos los alumnos 

        public Alumno[] ListarTodo() { return alumnos; }

        //Registrar alumnos

        public void Registrar(Alumno alumno)
        {
            alumnos[cont] = alumno;
            cont++;
        }

        //Eliminar Alumnos del arreglo 

        public void Eliminar(String codigo)
        {
            int posicion = Array.FindIndex(alumnos, alumno => alumno.Codigo == codigo);

            //logica de eliminacion
            for (int i = 0; i < cont; i++)
            {
                if (i >= posicion)
                {
                    alumnos[i] = alumnos[i + 1];
                }
            }
            cont--;

        }
        //Metodo comparacion

        private class MetodoComparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (((Alumno)x).Promedio < ((Alumno)y).Promedio) return -1; //Ordenar de forma ascendente
                else if (((Alumno)x).Promedio == ((Alumno)y).Promedio) return 0;
                else return 1;
            }

        }

        //Ordenar alumnos segun su promedio

        public Alumno[] Ordenar()
        {
            Array.Sort(alumnos, 0, cont, new MetodoComparacion());
            return alumnos;
        }

        //Buscar alumno segun su codigo

        public Alumno[] BuscarPorCodigo(String codigo)
        {
            return Array.FindAll(alumnos, alumno => alumno != null && alumno.Codigo.Contains(codigo));
        }
    }


}

