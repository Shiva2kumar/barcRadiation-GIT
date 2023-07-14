using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn3 : MonoBehaviour
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
        positions[0] = new Vector3(5, 0.5f, 27);
        positions[1] = new Vector3(70, 0.5f, 38);
        positions[2] = new Vector3(86, 0.5f, 38);
        positions[3] = new Vector3(92, 0.5f, 38);
        positions[4] = new Vector3(83, 0.5f, -86);
        positions[5] = new Vector3(85, 0.5f, 61);
        positions[6] = new Vector3(91, 0.5f, 14);
        positions[7] = new Vector3(23, 0.5f, 57);
        positions[8] = new Vector3(84, 0.5f, 59);
        positions[9] = new Vector3(23, 0.5f, 7);
        positions[10] = new Vector3(73, 0.5f, 8);
        positions[11] = new Vector3(-15, 0.5f, 33);
        positions[12] = new Vector3(-61, 0.5f, 10);
        positions[13] = new Vector3(-75, 0.5f, 22);
        positions[14] = new Vector3(-90, 0.5f, 63);
        positions[15] = new Vector3(-10, 0.5f, 68);
        positions[16] = new Vector3(-10, 0.5f, 86);
        positions[17] = new Vector3(-20, 0.5f, -26);
        positions[18] = new Vector3(-57, 0.5f, -21);
        positions[19] = new Vector3(-50, 0.5f, -50);
        positions[20] = new Vector3(8, 0.5f, -45);
        positions[21] = new Vector3(-50, 0.5f, -73);
        positions[22] = new Vector3(-50, 0.5f, -90);
        positions[23] = new Vector3(-84, 0.5f, -82);
        positions[24] = new Vector3(-58, 0.5f, -49);
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
