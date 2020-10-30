using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Add a public variable - to be assigned from editor
    public GameObject player;
    // Add a public variable for camera offset
    public Vector3 camera_offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + camera_offset;
    }
}
