using OperacionesBasicas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas.Negocios
{
    class ClsOperaciones
    {
        public double Suma(Operaciones operacion)
        {
            operacion.Resultado = operacion.Dato1 + operacion.Dato2;
            return operacion.Resultado;
        }
        public double Resta(Operaciones operacion)
        {
            operacion.Resultado = operacion.Dato1 - operacion.Dato2;
            return operacion.Resultado;
        }

        public double Multiplicacion(Operaciones operacion)
        {
            operacion.Resultado = operacion.Dato1 * operacion.Dato2;
            return operacion.Resultado;
        }

        public double Division(Operaciones operacion)
        {
            operacion.Resultado = operacion.Dato1 / operacion.Dato2;
            return operacion.Resultado;
        }
    }
}
