using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private float jumpPosX = 1;
    private float jumpPosY = 1;
    private float jumpPosZ = 0;
    Rigidbody playerRb;


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        PlayerJump();
        PlayerJump();
    }


    private void PlayerJump()
    {
        Vector3 jumpPos = new Vector3(jumpPosX,jumpPosY,jumpPosZ);
        playerRb.AddForce(Vector3.forward * 1000);
        Debug.Log("123");
    }
}
