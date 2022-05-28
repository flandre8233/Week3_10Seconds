using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerNameTextUI : MonoBehaviour
{
    [SerializeField] Player player;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        KeyCode keyCode = player.KeyCode;
        text.text = keyCode.ToString();
    }


}
