using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafFormation : MonoBehaviour
{
    
// Update is called once per frame
   void Update()
   {
   }

    void Start()
    {
        float Range = Random.Range(1.5f, 2.5f);
        float RangeStable = (Range + 0);
        transform.localScale = new Vector3(RangeStable, (RangeStable / 3), RangeStable);

    }

  
}

