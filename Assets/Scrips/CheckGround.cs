using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool tierra;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tierra = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        tierra = false;
    }
}
