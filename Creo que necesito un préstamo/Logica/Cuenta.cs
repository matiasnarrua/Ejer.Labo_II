using System;

namespace Logica
{
    public class Cuenta
    {
        public string titular;
        public float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public void SetTitular(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.titular = value;
            }
        }

        public string Mostrar() 
        {
            return $"La cuenta del titular {this.titular} Tiene ${this.cantidad} en la cuenta";
        }

        public void Retirar(float value)
        {
             this.cantidad -= value; 
        }

        public void Ingresar(float value)
        {
            this.cantidad += value;
        }




    }
}
