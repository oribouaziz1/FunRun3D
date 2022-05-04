using UnityEngine;
using System;
using System.Threading.Tasks;
using UnityEngine.Networking;

public class Destoryer : NetworkBehaviour
{
    // Start is called before the first frame update
    [SerializeField]public GameObject Block;
    [SerializeField]public GameObject Button;
    [SerializeField]public GameObject Canvas;
    void Start()
    {
        
       
        
    }

    // Update is called once per frame
    
    public void PleaseDestroyServerRpc(){
        Destroy(Block.gameObject);
        //Destroy(Button.gameObject);
        
    }
       // PleaseDestroyClientRpc();
    
    public void PleaseDestroyClientRpc(){
        Destroy(Block);
        Destroy(Button.gameObject);
    }
    
}
