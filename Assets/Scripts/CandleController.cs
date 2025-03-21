using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleController : MonoBehaviour
{

    public GameObject candleLight;
    public GameObject candleSmoke;
    public GameObject candle;
    bool isCandleOn = true;

    void Start()
    {
        candleLight.SetActive(true);
        candleSmoke.SetActive(false);
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == candle)
                {
                    Debug.Log("hit candle");
                    ToggleCandle();
                }
            }
        }

        void ToggleCandle()
        {
            isCandleOn = !isCandleOn; // Toggle candle state

            if (isCandleOn)
            {
                candleLight.SetActive(true);
                candleSmoke.SetActive(false);
            }
            else
            {
                candleLight.SetActive(false);
                candleSmoke.SetActive(true);
                // Invoke("DisableSmoke", 4); // Disable smoke after 4 seconds
            }
        }


        void DisableSmoke()
        {
            candleSmoke.SetActive(false);
        }
    }
}


