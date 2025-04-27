using UnityEngine;

public class espada : item, IAplicarBuff
{
    public espada(string nombre) : base(nombre) { }

    public void AplicarBuff()
    {
        Debug.Log( Nombre + " equipada: ataque aumentado!");
    }
}
