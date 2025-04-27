using UnityEngine;

public interface IAtacable
{
    void Atacar();
}

public interface IDañable
{
    void RecibirDaño(int cantidad);
}

public interface IDropeable
{
    void DropearItem();
}

public class enemy : MonoBehaviour
{
    private string nombre;
    private int vida;
    private int ataque;

    public string Nombre { get => nombre;
        set => nombre = value; 
    }
    public int Vida { get => vida;
        set => vida = value; 
    }
    public int Ataque { get => ataque;
        set => ataque = value; 
    }

    public enemy(string nombre)
    {
        this.nombre = nombre;
        this.vida = 100;
        this.ataque = 10;
    }

    public enemy(string nombre, int vida, int ataque)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.ataque = ataque;
    }

    public void MostrarInfo()
    {
        Debug.Log("Soy " + nombre + " , Vida: " + vida + " , Ataque: "+ ataque);
    }
}
