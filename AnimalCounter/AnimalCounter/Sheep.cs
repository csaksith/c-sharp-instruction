namespace AnimalCounter {
    internal class Sheep : Animal{
        // property to store the name of the sheep
        public string Name { get; set; }
        public override string GetCountString() {
            return Count+" "+Name;
        }
    }
}
