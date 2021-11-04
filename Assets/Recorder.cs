using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Recorder : MonoBehaviour{
    [Header("位置が記録されるオブジェクト一覧")]
    public List<GameObject> posObjs;

    [Header("角度が記録されるオブジェクト一覧")]
    public List<GameObject> rotObjs;

    [Header("保存するディレクトリ")]
    public string savedDirectory;

    int column_size;
    List<float[]> data;

    string PrintData(float[] data){
        string txt = "";
        for(int i = 0; i < column_size; i++){
            txt = $"{txt}, {data[i]}";
        }
        Debug.Log(txt);
        return txt;
    }

    void Start(){
        column_size = posObjs.Count * 3 + rotObjs.Count * 3 + 1;
        data = new List<float[]>();
    }

    void FixedUpdate(){
        float[] recData = new float[column_size];
        int idx = 0;
        recData[idx++] = Time.time;
        for(int i = 0; i < posObjs.Count; i++){
            recData[idx++] = posObjs[i].transform.position.x;
            recData[idx++] = posObjs[i].transform.position.y;
            recData[idx++] = posObjs[i].transform.position.z;
        }
        for(int i = 0; i < rotObjs.Count; i++){
            recData[idx++] = rotObjs[i].transform.rotation.x;
            recData[idx++] = rotObjs[i].transform.rotation.y;
            recData[idx++] = rotObjs[i].transform.rotation.z;
        }
        data.Add(recData);
    }

    void OnApplicationQuit(){
        string now = DateTime.Now.ToString("yyyyMMdd-HHmmss");
        string savedFile = $"{savedDirectory}\\{now}.csv";
        using(StreamWriter sw = new StreamWriter(savedFile)){
            for(int i = 0; i < data.Count; i++){
                sw.WriteLine($"{i}{PrintData(data[i])}");
            }
        }
        Debug.Log($"{savedDirectory}");
    }
}
