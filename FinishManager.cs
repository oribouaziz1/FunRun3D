using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.Networking;
public class FinishManager : MonoBehaviour
{
    [SerializeField] public GameObject player1;
    
    [SerializeField] public GameObject Animation1;
   
    // Start is called before the first frame update
    void Start()
    {
        player1.SetActive(true);
        
        Animation1.SetActive(true);
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
