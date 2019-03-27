using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 0; // 0 Primer simulacro. 1 Segundo simulacro

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3.0)
            {
                salida++;
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < notas.Length; i++)
        {
            for (int n = i + 1; n < notas.Length; n++)
            {
                if (notas[i] > notas[n])
                {
                    double nel = notas[i];
                    notas[i] = notas[n];
                    notas[n] = nel;

                    string nelN = nombres[i];
                    nombres[i] = nombres[n];
                    nombres[n] = nelN;
                }
            }    
        }

        for (int i = 0; i < 5; i++)
        {
            salida[i] = nombres[i];
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] cosas = new string[nombres.Length]; 
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        int con = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 3.0)
            {
                cosas[con] = nombres[i];
                con++;
            }
        }
        string[] salida = new string[con];

        for (int i = 0; i < con; i++)
        {
            salida[i] = cosas[i];
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] cosasas = new string[nombres.Length];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        int contadordemierda = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            string ok = nombres[i];
            char letra = 'A';
            for (int a = 0; a < ok.Length; a++)
            {
                if (letra == ok[a])
                {
                    cosasas[contadordemierda] = nombres[i];
                    contadordemierda++;
                    break;
                }
            }
        }
        string[] salida = new string[contadordemierda];
        for (int i = 0; i < contadordemierda; i++)
        {
            salida[i] = cosasas[i];
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }
}


