using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
public class spawn : MonoBehaviour
{
    public GameObject[] obj = new GameObject[4];
    public GameObject Co, Cs, co, cs;
    public Vector3[] positions = new Vector3[30];
    public int i, j, k, l,q;
    bool create, stop;
 public void Start()
    {
        q = Random.Range(1, 4);
        for (int s = 0; s < q; s++)
        {
            obj[s].SetActive(true);
        }
        create = true;
        positions[0] = new Vector3(66, 0.5f, 35);
        positions[1] = new Vector3(37, 0.5f, 15);
        positions[2] = new Vector3(36, 0.5f, -63);
        positions[3] = new Vector3(60, 0.5f, -63); 
        positions[4] = new Vector3(66, 0.5f, 35);
        positions[5] = new Vector3(76, 0.5f, 47);
        positions[6] = new Vector3(72, 0.5f, 12);
        positions[7] = new Vector3(15, 0.5f, -38);
        positions[8] = new Vector3(29, 0.5f, 70);
        positions[9] = new Vector3(93, 0.5f, 54);
        positions[10] = new Vector3(25, 0.5f, 14);
        positions[11] = new Vector3(-70, 0.5f, 38);
        positions[12] = new Vector3(-81, 0.5f, 82);
        positions[13] = new Vector3(-66, 0.5f, -15);
        positions[14] = new Vector3(-47, 0.5f, -62);
        positions[15] = new Vector3(-28, 0.5f, -74);
        positions[16] = new Vector3(-50, 0.5f, -89);
        positions[17] = new Vector3(-42, 0.5f, 56);
        positions[18] = new Vector3(-23, 0.5f, 89);
        positions[19] = new Vector3(-23, 0.5f, 62);
        positions[20] = new Vector3(-51, 0.5f, -12);
        positions[21] = new Vector3(-44, 0.5f, -7);
        positions[22] = new Vector3(-20, 0.5f, 30);
        positions[23] = new Vector3(-20, 0.5f, 88);
        positions[24] = new Vector3(27, 0.5f, 88);
        positions[25] = new Vector3(84, 0.5f, 38);
        positions[26] = new Vector3(43, 0.5f, 13);
        positions[27] = new Vector3(-42, 0.5f, 56);
        positions[28] = new Vector3(43, 0.5f, -66);
        positions[29] = new Vector3(6, 0.5f, 46);
        positions[30] = new Vector3(-20, 0.5f, 46);
    }
    private void Update()
    {
            positionselect1();  
    }
    public void positionselect1()
    {
        if (create == true)
        {
            i = Random.Range(0, 30);
            j = Random.Range(0, 30);
            k = Random.Range(0, 30);
            l = Random.Range(0, 30);
            co = Instantiate(obj[0], positions[i], Quaternion.identity);
            Co = Instantiate(obj[1], positions[j], Quaternion.identity);
            Cs = Instantiate(obj[2], positions[k], Quaternion.identity);
            cs = Instantiate(obj[3], positions[l], Quaternion.identity);
            create = false;
        }
    }
    public void OnDisable()
    {
        Destroy(cs);
        Destroy(Cs);
        Destroy(Co);
        Destroy(co);
        obj[0].SetActive(false);
        obj[1].SetActive(false);
        obj[2].SetActive(false);
        obj[3].SetActive(false);
    }
}
