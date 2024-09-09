using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class BattleView :MonoBehaviour ,IBattleView
    {

        [Header("UnitState UI")]
        [SerializeField] private GameObject unitStateUi;
        [SerializeField] private Image HpUi;

        [Header("Buff UI")]
        [SerializeField] private BuffDisplayModel[] Buffs;
        [SerializeField] private BuffDisplayModel emptyBuffs = new BuffDisplayModel(null, 0);

        private IBattlePresenter presenter;

        public void ShowBuff(BuffDisplayModel getBuffs , int index)
        {
            Buffs[index] = getBuffs;
        }
        public void HideBuff(int index)
        {
            Buffs[index] = emptyBuffs;

        }

        public void FrontUnit(Image unit, Vector2 FrontVec)
        {
            unit.transform.position = FrontVec;
        }
        public void BackUnit(Image unit, Vector2 BackVec)
        {
            unit.transform.position = BackVec;
        }


        public void ShowUnitState()
        {
            unitStateUi.SetActive(true);
        }
        public void HideUnitState()
        {
            unitStateUi.SetActive(false);

        }
        public void UnitUpdate(UnitDisplayModel unit)
        {
            HpUi = unit.HpSprite;
        }
    }
}
