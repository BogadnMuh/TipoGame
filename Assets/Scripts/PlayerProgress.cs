using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public List<PlayerProgressLevel> levels;

    public RectTransform _expValTra;
    public TextMeshProUGUI _expText;

    private int _lvl = 1;

    public float _expCurVal = 0;
    public float _expTarVal = 100;

    public void Start()
    {
        SetLevel(_lvl);
        DrawUI();
    }
    public void AddExp(float value)
    {
        _expCurVal += value;
        if (_expCurVal >= _expTarVal)
        {
            SetLevel(_lvl + 1);
            _expCurVal = 0;
            _expText.text = _lvl.ToString();
        }
        DrawUI();
    }
    private void SetLevel(int value)
    {
        _lvl = value;

        var CurLvl = levels[_lvl - 1];
        _expTarVal = CurLvl.expUp;
        GetComponent<FireballCast>().damage = CurLvl.fireballDamage;

        var grenadeCaster = GetComponent<GrenadeCaster>();
        grenadeCaster.damage = CurLvl.grenadeDamage;

        if (CurLvl.grenadeDamage < 0)
            grenadeCaster.enabled = false;
        else
            grenadeCaster.enabled = true;
    }
    private void DrawUI()
    {
        _expValTra.anchorMax = new Vector2(_expCurVal / _expTarVal, 1);
    }
}
