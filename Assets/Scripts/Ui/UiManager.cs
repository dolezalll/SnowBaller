using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private CrossHairUiController _CrossHairUiController = null;
    public CrossHairUiController CrossHairUiController => _CrossHairUiController;

    [SerializeField] private MainMenuUiController _MainMenuUiController = null;
    public MainMenuUiController MainMenuUiController => _MainMenuUiController;

    [SerializeField] private GameOverUi _GameOverUi = null;
    public GameOverUi GameOverUi => _GameOverUi;

    [SerializeField] private LevelWinUiController _LevelWinUiController = null;
    public LevelWinUiController LevelWinUiController => _LevelWinUiController;

    [SerializeField] private LevelUiController _LevelUiController = null;
    public LevelUiController LevelUiController => _LevelUiController;

    [SerializeField] private ShopManager _ShopManager = null;
    public ShopManager ShopManager => _ShopManager;

    [SerializeField] private Tutorial _Tutorial = null;
    public Tutorial Tutorial => _Tutorial;

    public void Init()
    {
        
        _ShopManager.Init();
        _CrossHairUiController.Init();
        _MainMenuUiController.Init();
        _GameOverUi.Init();
        _LevelWinUiController.Init();
        _LevelUiController.Init();

        _CrossHairUiController.Unload();
        _MainMenuUiController.Load();
        _GameOverUi.Unload();
        _LevelWinUiController.Unload();
        _LevelUiController.Unload();
        _Tutorial.Init();
    }

    public void UpdateUi()
    {
        _LevelUiController.UpdateUiCanvas();
    }
}
