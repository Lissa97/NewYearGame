using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fon : MonoBehaviour
{
    public bool isRender = true;
    public bool isVisible = false;

    public void Refresh() {
        isRender = true;
        isVisible = false;
    }

    private void OnBecameInvisible()
    {
        isRender = false;
    }

    private void OnBecameVisible()
    {
        isVisible = true;
    }
}
