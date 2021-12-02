using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForrestGenerator : MonoBehaviour
{
    //integer that sets the size of the forest and allows you to change it in the inspector
    //
    public int forestSize = 25;
    //Spacing between elements e.g. trees, rocks, bushes etc.
    //
    public int elementSpacing = 3;

    public Element[] elements;

    public void Generate(float[,] heightMap)
    {
        for (int x = 0; x < forestSize; x += elementSpacing)
        {
            for (int z = 0; z < forestSize; z += elementSpacing)
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    Element element = elements[i];

                    if (element.CanPlace())
                    {
                        //Vector3 position = new Vector3(x, -31.2f, z);
                        Vector3 position = new Vector3(x, heightMap[x, z], z);

                        Vector3 offset = new Vector3(Random.Range(-0.75f, -0.75f), 0f, Random.Range(-0.75f, 0.75f));

                        Vector3 rotation = new Vector3(Random.Range(0, 5f), Random.Range(0, 360f), Random.Range(0, 5f));

                        Vector3 scale = Vector3.one * Random.Range(0.75f, 1.25f);

                        GameObject newElement = Instantiate(element.GetRandom());
                        newElement.transform.SetParent(transform);
                        newElement.transform.position = position + offset;
                        newElement.transform.eulerAngles = rotation;
                        newElement.transform.localScale = scale;
                        break;
                    }
                }
                

               
              
            }

        }
    }

}


//Make it serializable because we are setting it in the inspector
//
[System.Serializable]
public class Element //Element class 
{
    //name type of element prefab
    //
    public string name;
    [Range(1, 10)]
    public int density;

    //Space for Prefab to go in inspector
    //
    public GameObject[] prefabs;


    public bool CanPlace()
    {
        if (Random.Range(0, 10) < density)
            return true;
        else
            return false;
    }

    public GameObject GetRandom()
    {

        // Return a random GameObject prefab from the prefabs array.

        return prefabs[Random.Range(0, prefabs.Length)];

    }
}

    
