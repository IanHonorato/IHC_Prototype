using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuJogos : MonoBehaviour
{
    public TextMeshProUGUI descricao;
    public void btnJogo01() {
        descricao.text = "Este jogo é voltado para pessoas que suspeitam estar numa relação abusiva.";
    }

    public void btnJogo02()
    {
        descricao.text = "Este jogo é focado naqueles que conhecem alguém em situação de abuso";
    }

    public void btnJogo03()
    {
        descricao.text = "Venha aprender um pouco sobre métodos de diagnóstico de abuso infantil";
    }

    public void btnJogo04()
    {
        descricao.text = "Este jogo é voltado para pessoas que suspeitam ter sofrido abuso sexual.";
    }
}
