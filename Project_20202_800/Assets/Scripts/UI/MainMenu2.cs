using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{

    public Animator anim;
    public void PlayGame()
    {
        
        //Invocar a la transición de salida.
        anim.SetTrigger("Start");
        //Esperar que se ejecute.
        //Cambiar de Escena
        StartCoroutine(LoadLevel(1));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public IEnumerator LoadLevel(int buildIndex)
    {
        //Esperar que se ejecute.
        yield return new WaitForSeconds(1);
        //Cambiar de Escena
        SceneManager.LoadScene(buildIndex);
    }
}
