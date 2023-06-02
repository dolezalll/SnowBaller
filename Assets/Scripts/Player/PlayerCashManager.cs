using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCashManager : MonoBehaviour
{
    public int Cash => _Cash;
    [SerializeField] private int _Cash;
    //private int _Cash = 10;

    private GameManager _GameManager = null;
    // Start is called before the first frame update


    public int AddCoins(int amount)
    {
        // p�id� po�et minc� k aktu�ln�mu po�tu minc� hr��e
        _Cash += amount;

        return _Cash;



    }

    public int GetCash()
    {
        return _Cash;
    }
    public int ReduceCoins(int amount)
    {
        // ode�te po�et minc� k aktu�ln�mu po�tu minc� hr��e
        if (_Cash - amount >= 0)
        {
            _Cash -= amount;
        }
        else
        {
            _Cash = 0;
        }

        return _Cash;
    }



   }
