using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawn4 : MonoBehaviour
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
        positions[0] = new Vector3(-25, 0.5f, -18);
        positions[1] = new Vector3(17, 0.5f, -42);
        positions[2] = new Vector3(86, 0.5f, -12);
        positions[3] = new Vector3(64, 0.5f, 18);
        positions[4] = new Vector3(68, 0.5f, 46);
        positions[5] = new Vector3(12, 0.5f, 35);
        positions[6] = new Vector3(18, 0.5f, 53);
        positions[7] = new Vector3(29, 0.5f, 84);
        positions[8] = new Vector3(14, 0.5f, -34);
        positions[9] = new Vector3(20, 0.5f, -90);
        positions[10] = new Vector3(-31, 0.5f, -11);
        positions[11] = new Vector3(-13, 0.5f, 21);
        positions[12] = new Vector3(-13, 0.5f, 53);
        positions[13] = new Vector3(-13, 0.5f, 69);
        positions[14] = new Vector3(5, 0.5f, 93);
        positions[15] = new Vector3(68, 0.5f, 96);
        positions[16] = new Vector3(86, 0.5f, 91);
        positions[17] = new Vector3(95, 0.5f, 4);
        positions[18] = new Vector3(47, 0.5f, 14);
        positions[19] = new Vector3(10, 0.5f, -15);
        positions[20] = new Vector3(7, 0.5f, -43);
        positions[21] = new Vector3(9, 0.5f, -87);
        positions[22] = new Vector3(-61, 0.5f, -67);
        positions[23] = new Vector3(-68, 0.5f, -8);
        positions[24] = new Vector3(-68, 0.5f, 20);
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
