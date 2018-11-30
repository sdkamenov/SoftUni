using _08.MilitaryElite.Contracts;
using _08.MilitaryElite.Enums;

namespace _08.MilitaryElite.Models
{
    public class Mission : IMission
    {
        private string codeName;
        private State state;

        public Mission(string codeName, State state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            State = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
