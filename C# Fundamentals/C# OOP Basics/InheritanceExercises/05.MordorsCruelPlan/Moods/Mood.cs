namespace _05.MordorsCruelPlan.Moods
{
    public abstract class Mood
    {
        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }
    }
}
