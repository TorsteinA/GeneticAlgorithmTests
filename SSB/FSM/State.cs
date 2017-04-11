using Robocode;

namespace SeaSharpBot.FSM
{
	public abstract class State
	{
		protected SeaSharpBot OurRobot;

		public abstract float Relevance();

		public abstract void Execute();
	}
}
