using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class spwanPlayer : MonoBehaviour
{
    public GameObject SpwanPlayerr;

    public float minx, maxX, minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 randpos = new Vector2(Random.Range(minx, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(SpwanPlayerr.name, randpos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
