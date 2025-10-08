using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // M�todo a utilizar para iniciar el juego
    public void Iniciar()
    {
       
        SceneManager.LoadScene("GameScene");
    }

    // M�todo a utilizar para salir del juego
    public void Salir()
    {
        Debug.Log("Saliendo del juego..."); 
        Application.Quit(); 
    }
}