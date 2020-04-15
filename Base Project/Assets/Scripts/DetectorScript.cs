using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    static Vector3 velocity;
    static Vector3 velocity2;
    static Vector3 velocity3;
    static Vector3 velocity4;
    static Vector3 velocity5;
    int[] vectorRes = new int[5];

    bool full=false;
    bool escalera=false;
    bool poker=false;
    bool grande=false;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = DiceScript.velocity;
        velocity2 = Dice2Script.velocity2;
        velocity3 = Dice3Script.velocity3;
        velocity4 = Dice4Script.velocity4;
        velocity5 = Dice5Script.velocity5;
    }
  
    void OnTriggerStay(Collider collider) {
        if(velocity.x == 0f && velocity.y == 0 && velocity.z == 0 && velocity2.x == 0f && velocity2.y == 0 && velocity2.z == 0 && velocity3.x == 0f && velocity3.y == 0 && velocity3.z == 0 
        && velocity4.x == 0f && velocity4.y == 0 && velocity4.z == 0 && velocity5.x == 0f && velocity5.y == 0 && velocity5.z == 0){
            // Dice1-Side1
            string dado=collider.gameObject.name;
           
            
            string[] positions = dado.Split('-');
            
             if(positions[0] == "dice1"){

                DiceScript.diceNumber=numeroDado(positions[1])+"";
                
                vectorRes[0]=numeroDado(positions[1]);
                
            }
            if(positions[0] =="dice2"){
  
                Dice2Script.diceNumber2=numeroDado(positions[1])+"";
                vectorRes[1]=numeroDado(positions[1]);


            }if(positions[0] =="dice3"){
           
                Dice3Script.diceNumber3=numeroDado(positions[1])+"";
                vectorRes[2]=numeroDado(positions[1]);

            }if(positions[0] =="dice4"){
                Dice4Script.diceNumber4=numeroDado(positions[1])+"";
                vectorRes[3]=numeroDado(positions[1]);
            }if(positions[0] =="dice5"){
                Dice5Script.diceNumber5=numeroDado(positions[1])+"";
                vectorRes[4]=numeroDado(positions[1]);
            }

            int primero=vectorRes[0];
            int segundo=vectorRes[1];
            int tercero=vectorRes[2];
            int cuarto=vectorRes[3];
            int quinto=vectorRes[4];
            if(primero==segundo && segundo == tercero && tercero== cuarto && cuarto==quinto)
            {
                grande=true;
            }
            else{
                grande=false;
            }

            if(escalera==true){
                TextScriptResult.punto=1;
            } else if(full==true){
                TextScriptResult.punto=2;
            } else if(poker==true){
                TextScriptResult.punto=3;
            } else if(grande==true){
                TextScriptResult.punto=4;
            }
          
            
            

        }
       /* DiceScript.diceNumber=vectorRes[0]+"";
        Dice2Script.diceNumber2=vectorRes[1]+"";
        Dice3Script.diceNumber3=vectorRes[2]+"";
        Dice4Script.diceNumber4=vectorRes[3]+"";
        Dice5Script.diceNumber5=vectorRes[4]+"";*/
    }
    int numeroDado(string numero){
        if(numero=="Side1"){
            return 6;
        }else if(numero=="Side2"){
            return 5;
        }else if(numero=="Side3"){
            return 4;
        }else if(numero=="Side4"){
            return 3;
        }else if(numero=="Side5"){
            return 2;
        } else{
            return 1;
        }
    }
}
