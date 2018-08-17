using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;


public class MapReader : MonoBehaviour {
    void Start() {
        ReadString();
    }
    void Update() {
        
    }
    
    
    static void ReadString() {
        int row = 0;
        int col = 0;
        char next = '';

        string path = "Assets/Resources/map_1.txt";
        
        StreamReader reader = new StreamReader(path);

        string s = reader.ReadToEnd();
        char[] arr = s.ToCharArray();

        for (int i = 0; i < arr.Length; i++) {
            next = arr[i];

            if (next == '0') {
                row++;
            }
            else if (next == '1') {

            }
        }






        reader.Close();


    }

}
