using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Image image;
    private void Start()
    {
        button.onClick.AddListener(() =>
        {
            AvatarController.Instance.ChangeAvatar(image.sprite);
        });
    }

    /*private void OnValidate()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
    }*/
}
