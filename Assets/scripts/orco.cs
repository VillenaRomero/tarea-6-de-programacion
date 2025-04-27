using UnityEngine;

public class orco : enemy, IAtacable, IDañable, IDropeable
{
    public orco(string nombre, int vida, int ataque) : base(nombre, vida, ataque) { }

    public void Atacar()
    {
        Debug.Log( Nombre + " ataca con un garrote!");
    }

    public void RecibirDaño(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log(Nombre + " recibió " + cantidad + " de daño. Vida restante: " + Vida);
    }

    public void DropearItem()
    {
        Debug.Log($"{Nombre} dropea un garrote roto!");
    }
}
