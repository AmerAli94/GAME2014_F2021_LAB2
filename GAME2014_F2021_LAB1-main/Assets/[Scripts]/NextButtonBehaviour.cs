using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonBehaviour : MonoBehaviour
{
    public void OnNextPressed()
    {
        SceneManager.LoadScene("End");
    }
}
