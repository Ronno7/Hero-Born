using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    private int _playerHP = 10;
    public int MaxItems = 4;
    public Button WinButton;
    public Button LossButton;
    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;

    public void UpdateScene(string updatedText)
    {
        ProgressText.text = updatedText;
        Time.timeScale = 0f;
    }

    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
    }

    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            ItemText.text = "Items: " + Items;
            if (_itemsCollected >= MaxItems)
            {
                WinButton.gameObject.SetActive(true);
                UpdateScene("You've found all the items!");
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " more to go!";
            }

        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public int HP
    {
        get { return _playerHP; }
        set { _playerHP = value;
            HealthText.text = "Health: " + HP;
        if(_playerHP <= 0) 
            {
                LossButton.gameObject.SetActive(true);
                UpdateScene("You want another life with that?");
            }
        else
            {
                ProgressText.text = "Ouch... that's got to hurt.";
            }
            Debug.LogFormat("Lives: {0}", _playerHP); }
    }
}
