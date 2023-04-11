using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger_colider : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string tag;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == tag && enabled)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
