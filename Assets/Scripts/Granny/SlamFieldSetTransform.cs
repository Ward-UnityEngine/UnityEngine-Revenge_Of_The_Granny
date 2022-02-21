using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlamFieldSetTransform : MonoBehaviour
{
    private Transform m_transform;

    private void Awake()
    {
        m_transform = GetComponent<Transform>();
    }
    public void SetTransform(float posX)
    {
        m_transform.position = new Vector3( posX,m_transform.position.y, 0f);
    }

}
