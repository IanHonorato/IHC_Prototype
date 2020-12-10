using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuVideos : MonoBehaviour
{
    public TextMeshProUGUI descricao;
    public void btnVideo01()
    {
        descricao.text = "Vídeo explicativo sobre abuso infantil.";
    }

    public void btnVideo02()
    {
        descricao.text = "Vídeo conscientizador sobre relacionamento abusivo.";
    }

    public void btnVideo03()
    {
        descricao.text = "Vídeo sobre relações tóxicas";
    }

    public void btnVideo04()
    {
        descricao.text = "Este vídeo retrata como prevenir casos de abuso sexual infantil.";
    }

    public void btnDownload()
    {
        descricao.text = "Baixando vídeo...";
    }
}
