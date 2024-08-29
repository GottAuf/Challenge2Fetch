using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float cooldown = 0;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (cooldown <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cooldown = 1;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
        cooldown -= Time.deltaTime;
    }
}
