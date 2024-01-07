using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text win;
    public GameObject transition;
    public Text totalfruits;
    public Text fruitscollected;
    private int totalfruitsinlevel;

    private void Start()
    {
        totalfruitsinlevel = transform.childCount;
    }

    private void Update()
    {
        AllFruitsCollected();
        totalfruits.text = totalfruitsinlevel.ToString();
        fruitscollected.text = transform.childCount.ToString();
    }
    public void AllFruitsCollected ()
    {
        if (transform.childCount==0)
        {
            Debug.Log("No quedan Frutas");
       
            transition.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 

    }
}
