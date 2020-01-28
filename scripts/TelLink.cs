using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelLink : MonoBehaviour
{
    private void OnMouseDown()
    {
        Application.OpenURL("tel:593984789524");
    }
}
