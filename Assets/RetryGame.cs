using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   // Start is called before the first frame update
void Start()
   {
    
        }

    // Update is called once per frame
void Update()
    {
    
       }
}