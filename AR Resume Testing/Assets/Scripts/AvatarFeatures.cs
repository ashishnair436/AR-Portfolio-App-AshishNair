using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarFeatures : MonoBehaviour
{
    public Vector3 rotateAvatar;


    void Update()
    {
        transform.Rotate(rotateAvatar * Time.deltaTime);
    }
}
