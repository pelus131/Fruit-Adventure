using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject optionsPanel;
    public AudioSource clip;
    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void Return()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void QuitGame() { Application.Quit(); }
    public void Jugar() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }
    private void Update()
    {
        if ((Input.GetKey("escape")))
        {
            OptionsPanel();
            PlaysoundButton();
            
        }
        
    }
    public void PlaysoundButton() { clip.Play(); }
}
