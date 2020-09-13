using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace TMG.BloonsTD.UI
{
    public class GeneralUIController : MonoBehaviour
    {
        [SerializeField] private TMP_Text _roundValue;
        [SerializeField] private TMP_Text _moneyValue;
        [SerializeField] private TMP_Text _livesValue;
        [SerializeField] private Button _startRoundButton;

        public void UpdateRoundValue(string currentRound) =>
            _roundValue.text = currentRound.Equals(0.ToString()) ? 1.ToString() : currentRound;

        public void UpdatedMoneyValue(string currentMoney) => _moneyValue.text = currentMoney;

        public void UpdateLivesValue(string currentLives) => _livesValue.text = currentLives;

        public void ShowStartRoundButton() => _startRoundButton.gameObject.SetActive(true);

        public void HideStartRoundButton() => _startRoundButton.gameObject.SetActive(false);
    }
}