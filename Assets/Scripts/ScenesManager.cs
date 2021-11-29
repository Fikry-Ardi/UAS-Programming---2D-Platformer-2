using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenesManager : MonoBehaviour
{
    public GameObject losePanel;
    public GameObject winPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FinishLine"))
        {
            winPanel.SetActive(true);
        }

        else if (collision.CompareTag("Enemy"))
        {
            losePanel.SetActive(true);
        }
        
    }
}
