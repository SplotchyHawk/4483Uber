using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_assistant : MonoBehaviour
{
    private Text messageText;

    private void Awake()
    {
        messageText = transform.Find("messageText").GetComponent<Text>();
    }

    private void Start()
    {
        //messageText.text = "dabadee";
        //calling static function without needing an object reference intialized
        //TextWriter.AddWriterStatic(messageText, "mum i wanna go home", 0.2f, true); 
        if (Customer.whichCharacter == 0) { TextWriter.AddWriterStatic(messageText, "Don't talk to me before I've had me coffee", 0.1f, true); }
        else if (Customer.whichCharacter == 1) { TextWriter.AddWriterStatic(messageText, "Where were you when tilted towers went down? Oh um and bring me home please", 0.05f, true); }
        else if (Customer.whichCharacter == 2) { TextWriter.AddWriterStatic(messageText, "Отведи меня на секретную базу сейчас... UUhh I mean take me to normal home house american", 0.1f, true); }
        else if (Customer.whichCharacter == 3) { TextWriter.AddWriterStatic(messageText, "I must say, thy car is trash and geteth rideth of that yeeyeeth arse hair cut. Nevertheless taketh me to thy humble abode good sir", 0.1f, true); }
        else if (Customer.whichCharacter == 4) { TextWriter.AddWriterStatic(messageText, "GET ME HOME SO I CAN IGNORE MY WIFE AND CHUG PROTEIN POWDER BEFORE I GO APE MODE MY GUY", 0.1f, true); }
        else if (Customer.whichCharacter == 5) { TextWriter.AddWriterStatic(messageText, "Eyo rate my movie outta 10.... what a 9?!.. I'm taking this to twitter... ", 0.1f, true); }
        else if (Customer.whichCharacter == 6) { TextWriter.AddWriterStatic(messageText, "I ordered a grande maco lefty doopy shardiney at Starbucks but they all laughed at me. How was I supposed to know I walked into a Booster Juice", 0.03f, true); }
        else if (Customer.whichCharacter == 7) { TextWriter.AddWriterStatic(messageText, "Pweez needa swim, am fish at heart, where's tha neareth pool", 0.1f, true); }
        else if (Customer.whichCharacter == 8) { TextWriter.AddWriterStatic(messageText, "Take me to your house", 0.3f, true); }
        else if (Customer.whichCharacter == 9) { TextWriter.AddWriterStatic(messageText, "BOARK! BARK! BOWOW!! WOOOF! BORK! PORK! BOARK! BARK! BOWOW!! WOOOF! BORK! PORK!BOARK! BARK! BOWOW!! WOOOF! BORK! PORK!BOARK! BARK! BOWOW!! WOOOF! BORK! PORK!BOARK! BARK! BOWOW!! WOOOF! BORK! PORK!BOARK! BARK! BOWOW!! WOOOF! BORK! PORK!BOARK! BARK! BOWOW!! WOOOF! BORK! PORK!BOARK! BARK! BOWOW!! WOOOF! BORK! PORK!", 0.05f, true); }
        else if (Customer.whichCharacter == 10) { TextWriter.AddWriterStatic(messageText, "Oh you drive safely?... Hit the cars", 0.1f, true); }
        else if (Customer.whichCharacter == 11) { TextWriter.AddWriterStatic(messageText, "According to my calcumulationths this ride should only take twelve seconds", 0.1f, true); }
        else if (Customer.whichCharacter == 12) { TextWriter.AddWriterStatic(messageText, "Į̴̨̢̼͔͚̖̙̯̩̝̳̠̩͚̮͈̜̰̬̹̟̫̤̝͇̖̱̼͋̿'̶̧̥̫̰̪̗̲̝̳̜͔͐̀̔̓͒̏̑̊̆̒͛̑͛́͜͝v̶̡̯̰͚̝̙̗̩͖͓̬͔̠̟̎̋̎̐̋́͑̄̃͐̓̿͋͛̈́̕͘ͅe̸͎̬̩͉̲̖͐̍̈́̀̔͊̽̇̊͂͒͛͋͠͠ ̷̨̧̛̯̹̩̝̰͍̤̼̰͇̳̱͖͈̰͓̼͙̜̙̮̠͉͊̔̓͛͊̈̓͒͛͒͒̄̇͆̓̅̊͌͊̄̇͋́͌̊͝b̷̻̖̣̭̠̘͍͙̩͇͈̹͔̱͔͕̑͐̏̾̀̊͋͒̋̎̕ͅe̷̛͍͙̓͆͛̇̈́͂̆̀̃̚͘ę̵͎̹͌̀̀̏͗̾̒̊̏͂̅̈́̾̂͝͝ͅń̸̨̨̦̟̭̟͎̬͕̯̦̞̮͉̱͎̪̰͎͚̮̜̘̼̜͈̞̹̺̐̑̍̈́̑̿̈̎̑͊͒͒̕̚͝ͅ ̷̡̭̱̳̜̹̪̺̭̭͔̥̻̖̰͇͋̅̄͑́̿̈́̆͐̆̓̃̉̽́̀̃̽̒̏́̓̚̚͘̕͜ͅt̵̡̪̻̮̼̟̞̖̪̮̱̳̯̳͇̦̝̓̀͆ŗ̴̡̧̻̗̹͇̦̭͕͎̥͕̭̟̩̂́̇̒̍̿͌̅̒͌͛̆͑͘͝͝y̵̻̬͕̟̼͂̊́͊͝í̷̦̽̀̏́͘̚͝n̶̏̇̑ͅģ̶̢̢̞̖̤̗̩͉̪̩͖͇͙͙̼̣̺̗͎̪̙͂̈́͌́̒̎͒̈̎̔͂͑̑̈́͂͂́̈́͜͝͝͝ͅ ̵̡̡̧̝̱̣̮̘͇͇̣͍̫͎̦̟̞̠̭̭̝̻̣̥̙̫̲̃̓͊̂̒̈́̈́̽͐̐̾͐͒͂̕̕͘͝͝͝t̵̢̧̢̡̛̛͕͖͓̫̳͕̲̝̜̮̻̼͈̝̲͙̪̔́̋̑͆͛̂̈̂͂͑̓͝͝͝ȯ̷̡̟̲̘̼̳̊̕ͅ ̷̧̧̧̦͇̯̠̭͕̯͔͇͈͈̝͕̑͋̇̑͋̎̾́͛̒͘̚͜͝͝r̶̡̧̼̫̙͓͍̲̣͔̓̐͌̃̈́̊͗͌͆͂̀́̏͒̏̚͠e̸͈̲̎̀͐̕̚ą̵̨̧̢̛̣̳̘͈̲͔̬͓͚̙̰͈̭̥̺̦̺̱̬̣͖͈̼͓̟̩̾̾͂̇͑̔͋̌͒̽͌̏̾̐͑͌͒̌̇͐̍͛̀̓̕͝c̵̡̡͇͚͓̪͓̝̘̳͎̝͇͖͖̹̞̹̙̍̌̓̔͝ḩ̵̢͈͉͕̹̤̹̮̹͔͕͇̳̻̯͇̖̬́́̋̎̈́̆̈́̿̆̇͊͒̀̍͂̕͜͝ ̶̡̨̠̫̠̼̟̺̖̫̲̱̯͈̘̭̘̗̫̘͛́̆̈́̇͋̀͗̌̚ͅy̵̛͚̯͉̱̜͔̩͔̘͓̺̰͐̐͌̊͂̄̌̄̆͂̓̍̅͒͌̈́̋́̍͘͘͜ơ̷͈̝̝̞̣̠̗͖̻̊̈̍͋͑͆̿̈́̃̇̆͂͐̓̃̓̌͝͝͝͝u̴̬̱̣̘̤͉̿ ̵̧͍̪̣̭̙̩̟͖̘͈̳̳̪͍̩̮̼̤̼̜̲̅̕̚ͅą̸̧̜̘̮̯͍̙̤̺̰͔̮̖̗͉̥̩̮̟̺͔̭͖͑̂̔̈̐̉̏̉̌̂̾͌͒̈͐͗͑̓̃̚̚͜͜͠͠͝ͅḇ̸̧̨͔̟̥̟̣͈̯͚̽̀̚ǫ̶̛̱̗͔̥͙͓̬͓͎̿̔́͌̈́̑̇̓͑͗̃̓̃́̄̌̍̾̄̏͋̒͊̓͘͝͝͠u̶̦̺̩̬͔͊́̓́̀̂͗͘͜͜ţ̸̠̬̟̗̠͉̫̗̲͇̩̳̟̀͆̓́̎̊͌̎̽͌̀̓͂̇͊͝ ̸̛̬̹̫̟͋̀͊͊̾̍́̌͠͝ÿ̸̡̝͓̜̥͈̻̘̳̲̱͉͙̬̦͙̹̱̲͖̹̖́̑̔̏̌́̃̒̄̊͊̆͛̈́͑̀̉̍̇̐̓́͋͘͜ͅȍ̶̢̭̳͍̪͉͔̖̼͖̦̗̖͎͕̥̘̭͖̽͂̅̿̆̈́͋̉͋̿̄̓́͛̆̒̐̈̽̚ữ̷̡̧̳̜͔̙̫̌͗̊͒̄͆͛̃̀͗̾͒̿̓͆̒͛̈́̕̚͘͝ŗ̶̡̬̞̝̞̗̲̼͓̯̝͎̬̟͔̖̹̝͖̹̟̝̗͓͆̇̄͒̓̈́́̉̒̆̌̋͂̉͗̃̓͒̍͜͝ͅ ̴̛͉̬̤̻̦̜̰̣͌̓̆͗̆͛̌̀͐̈́̃́̈́́̾̓̾̊̉̕̕͝ͅç̷̧͓͕̥͓͖̭̘̩̺̼͋̅̒͐̾͊́̒̾̏̓̅̂̒̅̀̉̔̊̆͊͘͝a̴͕̫̼͕͋̋̒̾̎̈̃̉̽̅̿̉̈͛̕r̸̡̢̲̬͕͚͍͚̥̤̙̤͔͖͚͉̻̙̤̙͖͙̖͓̙̬̫̿̀̂̿͆̋͘'̸̜̬͕̭̪̮̹̠̳̖́̈́͗̽̓͌̀̿̉̔̊̿͊̀̃͊̚͘̕̚s̷̜̻͕̮͙̪̩͌͐̓͂͛̈́̌̆̋̋͂̚̚̚͝ͅ ̵̣͓̥̙̼̮̫͉̱͚͂̉͆̀̾̃̾̑͝e̵̢̪͎̝̲̹̟̰̼͔̲̱̗͚͖̥̜̘̦̟̜̒̌̈͜x̸̢̹̹̼̼̭̜̫͖̊̽͗̎̋̽̓̾̿̆̑̊̉̿̿̋̽̔͋͗̅́́̍̄͘͠͝ẗ̴̬̝̰̼͓̳́͊̔͐̋̑͌͆͐͒̀̇͝e̵̛̺̞̮̗͎͇͓̦̱̺̼̟̥͓̅̔͑͐͊̊̐͘̕̚͜n̸̡̨̢̫̝̞̙͙͉͚̪̼̤̹͔͙͇͖̦̯̺̫͉̱̠̯̅d̵̨̟̠̮̥̼̰͇̲͚̤͉̗͍͔̥̥̪̞̈́̾͗͘͜͜͠ẻ̸̛̼̞̻̭͙̥̟̝̓̎̚͝͠͝͝ͅd̶̨̨̧̻͉͔̠̦͙̥̹̻̜͈̳̝̲̯̹͕̠̯̖̰̖̈́̂̏̿̇̈́̔̒̋̀̔̀̃̿̈́̈́͂̚̕̚̚͜͠ͅ ̵̛̛̮͂̌͋̓̉̑̓̽̍͑͆̓̎̇̄̇̑́̿̈́̆͠͝͠͝w̸̡̢̡̢̨̬̹̖̠̖̥͈̠͇̣͖̼̯͙͔̠̯͖̙̩͌̃͌̍̑̔̆̂̑̂͆̂̂̈̾͑̄̎̃̈́̕͘͜͜͜͝ą̷̨͙͚͓̻̫̞͎̞̟̣̰̱͓̟͚̲̳̘͕̖̉̐̀̑̄̍̄͋̅̇̎̎͑ͅr̶̡̬̦̂̅̈́̊̽̍̍̌̾̆r̶̛̦̱̩̘̰̅̇́̊̇͒̈́͌̈́̈̔͗͑̆͐̇͛̒̚̕̕͜a̶̧̢̧̛̛̩̻̫̫̦͎͉̯͍͓̺̼͕̘̠͓̳̦̤̳̤̾̆̋̂͌̍̾̓̂̎̎̋̈́͊͜͝ͅn̸̨̢̛̲̹͍̭̹̝̮̣͇͚͇͖̖̠̘͈̺̺̘̻̞̻̬̳͚̖̱̆͊̏̈̍́͊̂̃̾̉̉̓̐̎̍̾̈́́͊͘̚̕͠͝͝t̸̡̧̻͇͍̯͓̹͚͍͎̫͕̍̓̀̽̌̐̀͜͝e̵̗̙̽̑͌̒͗̆ē̵̛͔̜̖̯̻͍̤̦͚̮̩̲̯̈̉̐͛̋̌́̄͆̅͐͑̿̿̾̎͝", 0.01f, true); }

    }
}
