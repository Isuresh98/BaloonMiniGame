using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
   [SerializeField] private int ClikToPop = 3;
    private void OnMouseDown()
    {
        ClikToPop--;

        transform.localScale += new Vector3(2f, 2f, 2f);

        if (ClikToPop <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
