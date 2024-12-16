using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HobCooker : MonoBehaviour
{
    public Material mat1;

    public float timeToCook = 10;
    private float timer;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Raw")
        {
            timer += Time.deltaTime;

            if (timer >= timeToCook)
            {
                other.tag = "FoodObject";
                other.GetComponent<MeshRenderer>().material = mat1;
                timer = 0;
            }
        }
    }
}