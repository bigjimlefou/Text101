using UnityEngine;

namespace Text101Namespace
{
    [UnityEngine.CreateAssetMenu(fileName = "anyState", menuName = "State", order = 0)]
    public class State : UnityEngine.ScriptableObject
    {
        [TextArea(14,10)][SerializeField] private string storyText;

        [SerializeField] private State[] nextStates;
        
        public string StoryText => storyText;
        
        public State[] NextStates => nextStates;
    }
}