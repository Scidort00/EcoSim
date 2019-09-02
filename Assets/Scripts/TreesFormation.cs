using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesFormation : MonoBehaviour
{
    private float EnergyUse;
    public float Energy;
    public Transform LeavesParentTrunk;
    public GameObject Trunk;
    public GameObject Leaves;
    void Start()
    {   float Range = Random.Range(0.2f, 0.5f);
        float StableRange = (Range + 0);
        transform.localScale += new Vector3(StableRange/2, StableRange, StableRange/2);
        Instantiate(Leaves, new Vector3(Trunk.transform.position.x, (Trunk.transform.localScale.y + (Trunk.transform.localScale.y / 5)), Trunk.transform.position.z), new Quaternion(0, 0, 0, 0), LeavesParentTrunk);
        transform.localScale += new Vector3(0, StableRange * (StableRange / 2), 0);
        transform.position += new Vector3(0, transform.localScale.y / 2, 0);
        EnergyUse = transform.localScale.x;
    }
    
    void Update()
    {
        TreesFormation.Energy -= EnergyUse * Time.deltaTime / 2;
    }
}
