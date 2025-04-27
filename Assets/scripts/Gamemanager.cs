using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    void Start()
    {
        orco orco = new orco("Grog", 150, 20);
        esqueleto esqueleto = new esqueleto("Huesitos");

        orco.MostrarInfo();
        esqueleto.MostrarInfo();

        orco.Atacar();
        esqueleto.Atacar();

        orco.RecibirDaño(30);
        orco.DropearItem();

        pocion pocion = new pocion("Poción de Vida");
        pocion.Consumir();

        espada espada = new espada("Espada de Fuego");
        espada.AplicarBuff();
    }
}
