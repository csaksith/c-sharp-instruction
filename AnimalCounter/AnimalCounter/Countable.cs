namespace AnimalCounter {
    internal interface ICountable {
        void IncrementCount();
        void ResetCount(); // was not needed in project
        string GetCountString();
    }
}
