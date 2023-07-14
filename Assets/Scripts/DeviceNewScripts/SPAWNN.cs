using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNN : MonoBehaviour
{
    public GameObject[] objj = new GameObject[4];
    public GameObject Coo, Css, coo, css;
    public Vector3[] positions = new Vector3[30];
    public int i, j, k, l, q;
    bool create, stop;
    public void Start()
    {
        q = Random.Range(0, 4);
        for (int s = 0; s < q; s++)
        {
            objj[s].SetActive(true);
        }
        create = true;
        positions[0] = new Vector3(14, 0, -60);
        positions[1] = new Vector3(58, 0, -60);
        positions[2] = new Vector3(58, 0, -86);
        positions[3] = new Vector3(60, 0, -63);
        positions[4] = new Vector3(83, 0, -86);
        positions[5] = new Vector3(91, 0.5f, -27);
        positions[6] = new Vector3(91, 0.5f, 14);
        positions[7] = new Vector3(91, 0.5f, 29);
        positions[8] = new Vector3(84, 0.5f, 59);
        positions[9] = new Vector3(59, 0.5f, 17);
        positions[10] = new Vector3(73, 0.5f, 8);
        positions[11] = new Vector3(38, 0.5f, 8);
        positions[12] = new Vector3(11, 0.5f, 13);
        positions[13] = new Vector3(48, 0.5f, 66);
        positions[14] = new Vector3(33, 0.5f, 95);
        positions[15] = new Vector3(-12, 0.5f, 83);
        positions[16] = new Vector3(-35, 0.5f, 66);
        positions[17] = new Vector3(-31, 0.5f, 39);
        positions[18] = new Vector3(-17, 0.5f, -20);
        positions[19] = new Vector3(-11, 0.5f, -70);
        positions[20] = new Vector3(8, 0.5f, -45);
        positions[21] = new Vector3(94, 0.5f, -5);
        positions[22] = new Vector3(86, 0.5f, 18);
        positions[23] = new Vector3(18, 0.5f, 26);
        positions[24] = new Vector3(49, 0.5f, 62);
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
            coo = Instantiate(objj[0], positions[i], Quaternion.identity);
            Coo = Instantiate(objj[1], positions[j], Quaternion.identity);
            Css = Instantiate(objj[2], positions[k], Quaternion.identity);
            css = Instantiate(objj[3], positions[l], Quaternion.identity);
            create = false;
        }
    }
    public void OnDisable()
    {
        Destroy(css);
        Destroy(Css);
        Destroy(Coo);
        Destroy(coo);
        objj[0].SetActive(false);
        objj[1].SetActive(false);
        objj[2].SetActive(false);
        objj[3].SetActive(false);
    }
}
