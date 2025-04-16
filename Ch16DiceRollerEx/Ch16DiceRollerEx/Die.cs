namespace Ch16DiceRollerEx {
    public class Die {
        public int Value { get; set; }
        public Die() {
            this.Value=0;
        }

        public void Roll() {
            // set the value to a random die roll.
            Random r = new Random();
            this.Value=r.Next(1,7);
        }
    }
}
