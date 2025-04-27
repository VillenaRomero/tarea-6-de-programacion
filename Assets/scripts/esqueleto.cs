using UnityEngine;

public class esqueleto : enemy, IAtacable, IDañable
{
    public esqueleto(string nombre) : base(nombre) { }

    public void Atacar()
    {
        Debug.Log(Nombre + " dispara una flecha!");
    }

    public void RecibirDaño(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log(Nombre + "  recibió "+ cantidad+ " de daño. Vida restante: " + Vida);
    }
}
