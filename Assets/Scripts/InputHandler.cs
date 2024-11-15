using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;//uses to type their user input
    [SerializeField] Text resultText; //text that is going to output for the results of the validation
    
    public Button Button;

    public InputField InputField;

    public string prefabTag = "Enemy";

    public void ValidateInput(){ //function is called when user clicks the buttn
        string input = inputField.text;
        
        if(input.Length < 3){
            resultText.text = "Invalid input";
            resultText.color = Color.red;
        }else{
            resultText.text = "";
            resultText.color = Color.blue;
            Button.enabled = false;
            inputField.enabled = false;
            
        }

    }

}
