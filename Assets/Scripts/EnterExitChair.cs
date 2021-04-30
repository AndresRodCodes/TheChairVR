using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExitChair : MonoBehaviour
{
    public GameObject chair;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(chair.transform.position.x, transform.position.y, chair.transform.position.z - 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}
