using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(GenereitObjects))]
public class GenEditor : Editor
{
    private GenereitObjects go;
    

    private void OnEnable()
    {
        go = (GenereitObjects)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Update")) Generate();

    
    }

    private void Generate()
    {
        for (int i = 0; i < go.path.Length; i++)
        {
            go.path[i].y = go.startPos.position.y;
           go.path[i].x = go.startPos.position.x+go.offset;
        }

       
            for (int i = 0; i < go.path.Length; i++)
            {
                GameObject newBut = Instantiate(go.ob, go.path[i],Quaternion.Euler(-90,0,0)) as GameObject;
            newBut.transform.parent = go.transform;
            }

        }
    }

