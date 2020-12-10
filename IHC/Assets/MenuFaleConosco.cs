using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuFaleConosco : MonoBehaviour
{
    public TMP_InputField input;
    public TextMeshProUGUI text;

    public void btnEnviar() {
        text.text = input.text;
    }
}
