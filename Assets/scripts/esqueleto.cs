using UnityEngine;

public class esqueleto : enemy, IAtacable, IDa�able
{
    public esqueleto(string nombre) : base(nombre) { }

    public void Atacar()
    {
        Debug.Log(Nombre + " dispara una flecha!");
    }

    public void RecibirDa�o(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log(Nombre + "  recibi� "+ cantidad+ " de da�o. Vida restante: " + Vida);
    }
}
