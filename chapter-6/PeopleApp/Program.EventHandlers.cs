using Packt.Shared;

partial class Program
{
  private static void Harry_shout(object? sender, EventArgs e)
	{
		// if no sender, then do nothing
		if(sender is null) return;

		// if sender is not a person, then do nothing
		if(sender is not Person p) return;

		WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
	}
}