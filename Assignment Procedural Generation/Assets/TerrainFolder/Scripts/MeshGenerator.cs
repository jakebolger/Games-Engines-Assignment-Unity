using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//get rid of 
//yield line
//change IEumerastor to void
//put updatemesh() into start method and get rid of update method
//get rid of "startcoroutine"
//get rid of gizmos method
// this is all to just generated mesh instantly

[RequireComponent(typeof(MeshFilter))] //makes sure theres always a mesh filter
public class MeshGenerator : MonoBehaviour
{
    //mesh varibale to store
    //
    Mesh mesh;

    
    //creating array of vetices
    //
    Vector3[] vertices;
    
    //array of triangles
    //
    int[] triangles;

    public int xSize = 20;
    public int zSize = 20;

    // Start is called before the first frame update
    void Start()
    {
        //creating new mesh object
        //
        mesh = new Mesh();
        //get mesh filter
        //
        GetComponent<MeshFilter>().mesh = mesh;
        CreateShape();
        //StartCoroutine(CreateShape());
        UpdateMesh();
        


    }

    //private void Update()
    //{
        //UpdateMesh();
    //}

    void CreateShape()
    {
        //defining vertices
        //
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];

        //for loop to loop though heights
        //
        for(int i = 0,  z = 0; z <= zSize; z++)
        {
            for(int x = 0; x <= xSize; x++)
            {
                //using poerlin noise 
                //
                float y = Mathf.PerlinNoise(x * .1f, z * .1f) * 1f;
                vertices[i] = new Vector3(x, y, z);
                i++;

            }
        }

        //specifiying trinagles
        //
        triangles = new int[xSize * zSize * 6];

        int vert = 0;
        int tris = 0;

        for(int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {

                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + xSize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xSize + 1;
                triangles[tris + 5] = vert + xSize + 2;

                vert++;
                tris += 6;

                //yield return new WaitForSeconds(.001f);
            }
            vert++;
        }

        
        
    }

    //to be able to use data from createshape function.
    //
    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }

    //private void OnDrawGizmos()
    //{
        //if (vertices == null)
            //return;

        //for(int i = 0; i < vertices.Length; i++)
        //{
            //Gizmos.DrawSphere(vertices[i], .1f);
        //}
    //}
}
