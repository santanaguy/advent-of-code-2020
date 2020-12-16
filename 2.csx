using System.Text.RegularExpressions;

void Main()
{
	var r = new Regex(@"(\d*)-(\d*) (.): (.*)");

	var values = File.ReadAllLines(@"C:\Users\Admin\Documents\Projetos\advent-of-code-2020\2.txt");
	int v = 0;
	foreach (var val in values)
	{
		var tmp = r.Match(val);
		var t = (int.Parse(tmp.Groups[1].Value), int.Parse(tmp.Groups[2].Value), tmp.Groups[3].Value[0], tmp.Groups[4].Value);

		if ((t.Item4[t.Item1 + 1] == t.Item3) ^ (t.Item4[t.Item2 + 1] == t.Item3))
		{
			v++;
		}
		
	}
}

// Define other methods, classes and namespaces here
