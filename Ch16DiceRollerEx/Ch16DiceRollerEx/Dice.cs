using ConsoleLibrary;

namespace Ch16DiceRollerEx {
    public class Dice {

        public Die Die1 { get; set; }
        public Die Die2 { get; set; }

        public Dice() {
            Die1=new Die();
            Die2=new Die();
        }

        public int Sum() {
            return this.Die1.Value+this.Die2.Value;
        }

        public void Roll() {
            this.Die1.Roll();
            this.Die2.Roll();
        }

        public string GetRollResult() {
            // changed requirement to return a string!
            string returnStr = "Die1: "+Die1.Value+"\n";
            returnStr+="Die1: "+Die2.Value+"\n";
            returnStr="Total: "+Sum()+"\n";
            if (Sum()==2) {
                returnStr+="Snake Eyes! \n";
            }
            else if (Sum()==12) {
                returnStr+="Box Cars!\n";
            }
            else if (Sum()==7) {
                returnStr+="Craps!\n";
            }
            return returnStr;
        }

    }
}
