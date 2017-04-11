namespace PG4500_2017_Exam1.FSM
{
	public abstract class State
	{
		protected alvtor_SeaSharpBot OurRobot;

		public abstract float Relevance();

		public abstract void Execute();
	}
}
