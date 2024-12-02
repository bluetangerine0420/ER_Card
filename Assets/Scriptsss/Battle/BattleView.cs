using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BattleView : MonoBehaviour, IBattleView
{
    [Header("Unit UI")]
    [SerializeField] private Image[] UnitImages;

    [Header("Change UI")]
    [SerializeField] private GameObject changeUi;
    [SerializeField] private GameObject changeBoutton;

    [Header("UnitState UI")]
    [SerializeField] private GameObject unitStateUi;
    [SerializeField] private Image HpUi;

    [Header("TurnStart UI")]
    [SerializeField] private GameObject bigTurnStartUi;
    [SerializeField] private GameObject smallTurnStartUi;
    
    [Header("TurnEnd UI")]
    [SerializeField] private GameObject bigTurnEndUi;
    [SerializeField] private GameObject smallTurnEndUi;

    [Header("Buff UI")]
    [SerializeField] private BuffDisplayModel[] Buffs;
    [SerializeField] private BuffDisplayModel emptyBuffs = new BuffDisplayModel(null, null, 0);

    [Header("Credit UI")]
    [SerializeField] private GameObject getCreditUi;     
    [SerializeField] private TextMeshPro getCreditValue;
    [SerializeField] private GameObject lossCreditUi;     
    [SerializeField] private TextMeshPro lossCreditValue;
    
    [Header("FirstPlayerPick")]
    [SerializeField] private GameObject firstPlayerUi;     
    [SerializeField] private GameObject sceondPlayerUi;

    private IBattlePresenter m_battlePresenter;
    [SerializeField] Vector2 FrontVec;
    [SerializeField] Vector2 BackVec;

    public void FirstPlayer(bool isPlayer1_First)
    {
        if(isPlayer1_First)
        {
            firstPlayerUi.SetActive(true);
        }
    }
    public void BigTurnStart()
    {
        bigTurnStartUi.SetActive(true);
    }

    public void GetCredit()
    {
        getCreditUi.SetActive(true);
    }
    public void LossCredit()
    {
        lossCreditUi.SetActive(true);
    }

    public void ShowBuff(BuffDisplayModel getBuffs, int index)
    {
        Buffs[index] = getBuffs;
    }
    public void HideBuff(int index)
    {
        Buffs[index] = emptyBuffs;

    }

    public void FrontUnit(Image unit)
    {
        unit.rectTransform.position = new Vector2(unit.rectTransform.position.x, FrontVec.y);
    }

    public void BackUnit()
    {
        for (int i = 0; i < UnitImages.Length; i++)
        {
            UnitImages[i].rectTransform.position = new Vector2(UnitImages[i].rectTransform.position.x, BackVec.y);
        }
    }


    public void ShowUnitState()
    {
        unitStateUi.SetActive(true);
    }
    public void HideUnitState()
    {
        unitStateUi.SetActive(false);

    }
    public void UnitStateUpdate(UnitDisplayModel unit)
    {
        HpUi = unit.HpSprite;
    }
    public void ShowSkillEffect(SkillDisplayModel skillEffect)
    {
        skillEffect.SkillAnimation.Play();
    }

    public void ShowChangeUi()
    {
        changeUi.SetActive(true);
    }
    public void HideChangeUi()
    {
        changeUi.SetActive(false);
    }

    public void BigTurnEnd()
    {
        bigTurnEndUi.SetActive(true);
        bigTurnEndUi.SetActive(false);
    }

    public void SmallTurnEnd()
    {
        smallTurnEndUi.SetActive(true);
        smallTurnEndUi.SetActive(false);
    }

    public void FirstPlayer()
    {

    }

}
