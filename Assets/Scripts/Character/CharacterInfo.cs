using System;

namespace Character
{
    [Serializable]
    public class CharacterInfo
    {
        public CharacterStats stats;

        private void Start()
        {
            stats.AddStat(CharacterStatType.Health,new CharacterStat(1000));
            stats.GetStat(CharacterStatType.Health).ResetCurrentByValue();
            
            stats.AddStat(CharacterStatType.Damage,new CharacterStat(100));
        }
    }
}