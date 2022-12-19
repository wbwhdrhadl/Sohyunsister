using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SENE_CHANGE : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Indoors");
    }
}