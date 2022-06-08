using UnityEngine;

namespace Character
{
    public class CharacterStatBar : MonoBehaviour
    {
        [SerializeField] private CharacterStatType statType;
        [SerializeField] private Character character;
        [SerializeField] private ProcessBar processBar;

        private void Awake() => character.health.OnValueChanged += OnHealthValueChanged;
        
        private void OnHealthValueChanged()
        {
            processBar.UpdateView(character.health.Percent);
            Debug.Log($"<color=red>{character.health.Current}</color>/{character.health.Value}");
        }
    }
}