using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("MenuGame");
    }

    public void OpcionesJuego()
    {
        SceneManager.LoadScene("OpcionesJuego");
    }
    public void CreditosJuego()
    {
        SceneManager.LoadScene("CreditosJuego");
    }


    public void SalirJuego()
    {
        Debug.Log("Salir Juego");
        Application.Quit();
    }

}
