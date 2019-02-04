namespace BadCode
{
    public class Match
    {
        private Team firstOpponent;
        public Team FirstOpponent
        {
            get
            {
                return firstOpponent;
            }
            set
            {
                firstOpponent = value;
            }
        }
        private Team secondOpponent;
        public Team SecondOpponent
        {
            get
            {
                return secondOpponent;
            }
            set
            {
                secondOpponent = value;
            }
        }
        private Team winner;
        public Team Winner
        {
            get
            {
                return winner;
            }
            set
            {
                winner = value;
            }
        }
    }
}
