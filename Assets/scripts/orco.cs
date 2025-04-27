using UnityEngine;

public class orco : enemy, IAtacable, IDa�able, IDropeable
{
    public orco(string nombre, int vida, int ataque) : base(nombre, vida, ataque) { }

    public void Atacar()
    {
        Debug.Log( Nombre + " ataca con un garrote!");
    }

    public void RecibirDa�o(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log(Nombre + " recibi� " + cantidad + " de da�o. Vida restante: " + Vida);
    }

    public void DropearItem()
    {
        Debug.Log($"{Nombre} dropea un garrote roto!");
    }
}
