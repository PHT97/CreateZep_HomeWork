using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameOutput : MonoBehaviour
{
    [SerializeField] private TMP_Text PlayerName;
    // Start is called before the first frame update
    void Start()
    {
        PlayerName.text = GameManager.instance.OutputPlayerName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
