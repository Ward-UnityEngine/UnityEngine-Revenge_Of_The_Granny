using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisbableCanvas : MonoBehaviour
{
    private void Start()
    {
        Invoke("DestroyThisGameobject", 3f);
    }

    private void DestroyThisGameobject()
    {
        Destroy(this.gameObject);
    }
}
