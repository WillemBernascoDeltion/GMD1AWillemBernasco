using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
    public Canvas menuCanvas;
    public Canvas ingameCanvas;

    void Awake()
    {
        ingameCanvas.enabled = false;
    }

    public void OptionsOn()
    {
        menuCanvas.enabled = true;
        ingameCanvas.enabled = false;
    }

    public void LoadOn()
    {
        Application.LoadLevel (1);
    }
}
