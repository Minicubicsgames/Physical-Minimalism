using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedGameObject : MonoBehaviour
{
    private void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Destroy(cube);
    }
}
