using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataScore : MonoBehaviour
{
    public static int coin = 0;

    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        coin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Coins : " + coin.ToString("000");
    }

}
