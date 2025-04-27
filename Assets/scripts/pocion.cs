using UnityEngine;

public class pocion : item, IConsumible
{
    public pocion(string nombre) : base(nombre) { }

    public void Consumir()
    {
        Debug.Log(Nombre + " consumida: vida restaurada!");
    }
}
