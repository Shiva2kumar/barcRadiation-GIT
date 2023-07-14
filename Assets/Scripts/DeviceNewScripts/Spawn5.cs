using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn5 : MonoBehaviour
{
    public GameObject[] objjj = new GameObject[4];
    public GameObject Co, Cs, co, cs;
    public Vector3[] positions = new Vector3[30];
    public int i, j, k, l, q;
    bool create, stop;
    public void Start()
    {
        q = Random.Range(1, 4);
        for (int s = 0; s < q; s++)
        {
            objjj[s].SetActive(true);
        }
        create = true;
        positions[0] = new Vector3(64, 0.5f, -9);
        positions[1] = new Vector3(35, 0.5f, 16);
        positions[2] = new Vector3(35, 0.5f, 64);
        positions[3] = new Vector3(11, 0.5f, 60);
        positions[4] = new Vector3(-7, 0.5f, 23);
        positions[5] = new Vector3(-34, 0.5f, 13);
        positions[6] = new Vector3(-44, 0.5f, -2);
        positions[7] = new Vector3(-71, 0.5f, -9);
        positions[8] = new Vector3(-63, 0.5f, -43);
        positions[9] = new Vector3(13, 0.5f, 62);
        positions[10] = new Vector3(37, 0.5f, 60);
        positions[11] = new Vector3(-45, 0.5f, -3);
        positions[12] = new Vector3(-46, 0.5f, 70);
        positions[13] = new Vector3(73, 0.5f, 13);
        positions[14] = new Vector3(-63, 0.5f, 16);
        positions[15] = new Vector3(-68, 0.5f, -34);
        positions[16] = new Vector3(-46, 0.5f, 61);
        positions[17] = new Vector3(-22, 0.5f, 26);
        positions[18] = new Vector3(38, 0.5f, 8);
        positions[19] = new Vector3(71, 0.5f, 13);
        positions[20] = new Vector3(-46, 0.5f, -18.5f);
        positions[21] = new Vector3(-68, 0.5f, 20);
        positions[22] = new Vector3(-68, 0.5f, 60);
        positions[23] = new Vector3(18, 0.5f, 53.5f);
        positions[24] = new Vector3(-66, 0.5f, 60);
    }
    private void Update()
    {
        positionselect1();
    }
    public void positionselect1()
    {
        if (create == true)
        {
            i = Random.Range(0, 24);
            j = Random.Range(0, 24);
            k = Random.Range(0, 24);
            l = Random.Range(0, 24);
            co = Instantiate(objjj[0], positions[i], Quaternion.identity);
            Co = Instantiate(objjj[1], positions[j], Quaternion.identity);
            Cs = Instantiate(objjj[2], positions[k], Quaternion.identity);
            cs = Instantiate(objjj[3], positions[l], Quaternion.identity);
            create = false;
        }
    }
    public void OnDisable()
    {
        Destroy(cs);
        Destroy(Cs);
        Destroy(Co);
        Destroy(co);
        objjj[0].SetActive(false);
        objjj[1].SetActive(false);
        objjj[2].SetActive(false);
        objjj[3].SetActive(false);
    }

}
