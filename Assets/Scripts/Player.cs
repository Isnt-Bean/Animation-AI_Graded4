using UnityEngine;
using System;
public class Player : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        transform.Translate(direction * speed * Time.deltaTime);
        
    }
}
