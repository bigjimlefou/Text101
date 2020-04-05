using Text101Namespace;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;
    [SerializeField] private State maxMovesGameOverState;
    [SerializeField] private int movesCountMax;
    
    private State state;
    public int movesCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.StoryText;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        if (Input.anyKeyDown)
        {
            var nextStates = state.NextStates;

            for (int i = 0; i < nextStates.Length; i++)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1 + i))
                {
                    state = nextStates[i];
                    movesCounter++;
                }
            }

            if (movesCounter >= movesCountMax)
            {
                state = maxMovesGameOverState;
                movesCounter = -1;
            }
            textComponent.text = state.StoryText;
        }
    }
}
