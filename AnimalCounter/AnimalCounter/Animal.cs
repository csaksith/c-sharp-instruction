namespace AnimalCounter {

    public abstract class Animal : ICountable {
        public int Count { get; set; } // property store the Count of animals

        public Animal() {
            this.Count=0;
        }

        public abstract string GetCountString();

        public void IncrementCount() {
            Count++;
        }

        public void ResetCount() {
            Count=0;
        }
    }
}