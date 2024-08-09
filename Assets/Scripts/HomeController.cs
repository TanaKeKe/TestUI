using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeController : MonoBehaviour
{
    [SerializeField] private GameObject BlurBackGround;
    public void SetProfile()
    {
        BlurBackGround.SetActive(true);
    }
}
