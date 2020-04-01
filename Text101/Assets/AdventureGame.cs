using System.Collections;
using System.Collections.Generic;
using Text101Namespace;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;
    
    private State state;
    
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = startingState.StoryText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
