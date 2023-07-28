using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainProcess : MonoBehaviour
{
    [Header("First Process Items")] 
    public InputField firstNameFirstInput;
    public InputField lastNameFirstInput;
    public InputField ageFirstInput;
    
    [Header("Second Process Items")] 
    public InputField firstNameSecondInput;
    public InputField lastNameSecondInput;
    public InputField ageSecondInput;
    
    [Header("Example")] 
    [SerializeField] TMP_Text resultText;
   

    public void ButtonClick()
    {
        Insan insan1 = new Insan();//instance ornegi
        insan1.FirstName = firstNameFirstInput.text;//set
        insan1.LastName = lastNameFirstInput.text;
        insan1.Age = int.Parse(firstNameFirstInput.text);
        
        if (insan1.Age<1 || insan1.Age>200)
        {
            insan1.Age = 18;
            Debug.LogError("Aykiri Durum");
            throw new System.Exception("Hata Oldu");
        }

        resultText.text = insan1.FirstName;//get
    }
    
    
   public void ButtonClickSecond()
    {
        Insan insan1 = new Insan();//instance ornegi
        insan1.FirstName = firstNameFirstInput.text;
        insan1.LastName = lastNameFirstInput.text;
        insan1.Age = int.Parse(firstNameFirstInput.text);
        
        if (insan1.Age<1 || insan1.Age>200)
        {
            insan1.Age = 18;
            Debug.LogError("Aykiri Durum");
            throw new System.Exception("Hata Oldu");
        }
    }
}
