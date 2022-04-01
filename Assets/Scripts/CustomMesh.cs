using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct CustomMesh
{
    private Vector3[] _vertices;
    private int[] _triangles;
    public Mesh mesh;

    public CustomMesh(Vector3[] vertices, int[] triangles)
    {
        _vertices = vertices;
        _triangles = triangles;

        mesh = new Mesh();
        mesh.vertices = _vertices;
        mesh.triangles = _triangles;
    }

    public static CustomMesh GenerateCubeMesh()
    {
        var vertices = CubeMeshData.Vertices;
        var triangles = CubeMeshData.Triangles;
        CustomMesh mesh = new CustomMesh(vertices, triangles);
        return mesh;
    }
    private static class CubeMeshData
    {
        public static readonly Vector3[] Vertices = new Vector3[]
        {
            new Vector3(0, 0, 0), //0
            new Vector3(0, 1, 0), //1
            new Vector3(1, 0, 0), //2
            new Vector3(1, 1, 0), //3
            new Vector3(0, 0, 1), //4
            new Vector3(0, 1, 1), //5
            new Vector3(1, 0, 1), //6
            new Vector3(1, 1, 1) //7
            
        };
    
        public static readonly int[] Triangles = new int[]
        {
            //front square
            0,1,2,
            2,1,3,
            //right square
            2,3,6,
            6,3,7,
            //left square
            0,4,1,
            4,5,1,
            //back square
            4,6,5,
            6,7,5,
            //top square
            1,5,3,
            5,7,3,
            //bottom square
            0,2,4,
            2,6,4
        };
    }
}


