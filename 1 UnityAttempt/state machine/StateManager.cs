using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    BaseState currS;
    public O1 o1 = new O1();
    public O2 o2 = new O2();
    public O3 o3 = new O3();

    public SCO1 sco1;

    public GameObject Story;
    public TextMeshProUGUI big;
    public Button DialogBtn;
    public TextMeshProUGUI DialogeBtnTxt;

    public GameObject smallGO;
    public TextMeshProUGUI small;
    public GameObject l2;
    public GameObject l3;
    public GameObject l4;


    public Button G2_1;
    public Button G2_2;

    public Button G3_1;
    public Button G3_2;
    public Button G3_3;
    
    public Button G4_1;
    public Button G4_2;
    public Button G4_3;
    public Button G4_4;


  
    void Start()
    {
      currS = o1;
      currS.EnterState(this);
    }

    void Update()
    {
      currS.UpdateState(this);
    }

    public void SwitchState(BaseState state)
    {
      currS = state;
      state.EnterState(this);
    }
}
