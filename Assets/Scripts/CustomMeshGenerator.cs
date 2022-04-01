using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMeshGenerator : MonoBehaviour
{
    private void Start()
    {
        CreateCube();
    }

    private void CreateCustomMesh(Vector3[] vertices, int[] triangles)
    {
        GameObject go = CreateCustomMeshGameObject();
        CustomMesh customMesh = new CustomMesh(vertices, triangles);
        MeshFilter mf = go.GetComponent<MeshFilter>();
        mf.sharedMesh = customMesh.mesh;
    }

    private void CreateCube()
    {
        GameObject go = CreateCustomMeshGameObject();
        CustomMesh customMesh = CustomMesh.GenerateCubeMesh();
        MeshFilter mf = go.GetComponent<MeshFilter>();
        mf.sharedMesh = customMesh.mesh;
    }

    private GameObject CreateCustomMeshGameObject()
    {
        GameObject meshGo = new GameObject
        {
            transform =
            {
                parent = transform,
                localPosition = Vector3.zero
            }
        };
        meshGo.AddComponent<MeshFilter>();
        meshGo.AddComponent<MeshRenderer>();
        return meshGo;
    }
}

