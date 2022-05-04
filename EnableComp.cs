using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class EnableComp : MonoBehaviour
{
    // Start is called before the first frame update
    private Movement movement;
    private PlayerSetUp setUp;
    private bool initilaize = true;
    [SerializeField] public Camera camara;
    [SerializeField] public GameObject cam;
    [SerializeField] public GameObject Block;
    void Start()
    {
        
        //if(initilaize){
            //initilaizeVars();
        //}
        
    }

    public void initilaizeVars(){
       // initilaize = false;
       // setUp = GetComponent<PlayerSetUp>();
       // movement = GetComponent<Movement>();
       // Debug.Log( setUp.enabled);
       // Debug.Log( movement.enabled);
         //setUp.enabled = false;
       // movement.enabled = false;
        //camera.SetActive(false);
       // Debug.Log( setUp.enabled);
       // Debug.Log( setUp.enabled);
       // Debug.Log( movement.enabled);
    }
    void Update(){
      //  Debug.Log( setUp.enabled);
      //  Debug.Log( movement.enabled);
    }
    

    [ServerRpc]
    public void EnableServerRpc(){
        
        Debug.Log("Destroy");
        EnableClientRpc();
    }
    [ClientRpc]
    public void EnableClientRpc(){
        cam.SetActive(true);
        camara.enabled = true ; 
        
        
    }

    // Update is called once per frame
    
}
