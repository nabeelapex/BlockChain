using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MetaMask.Unity;
public class me : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MetaMaskUnity.Instance.Initialize();
        var wallet = MetaMaskUnity.Instance.Wallet;
        wallet.Connect();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
