using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_on_touch : MonoBehaviour
{
    [SerializeField] string tag;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {   
        Debug.Log(other.tag);
        if (other.tag == tag && enabled)
        {    
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
