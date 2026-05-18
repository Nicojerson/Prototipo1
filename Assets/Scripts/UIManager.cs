using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject goCartelPresione;
    // Start is called before the first frame update
    void Start()
    {
        goCartelPresione = GameObject.FindGameObjectWithTag("CartelPresione");
        HideCartelpresione();
    }

    public void ShowCartelPresione()
    {
        goCartelPresione.SetActive(true);
    }
    public void HideCartelpresione()
    {
        goCartelPresione.SetActive(false);
    }
}
