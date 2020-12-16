<Query Kind="Program" />

void Main()
{
	var r = new Regex(@"(\d*)-(\d*) (.): (.*)");
	
	var values = File.ReadAllLines(@"C:\Users\Admin\Documents\Projetos\advent-of-code-2020\2.txt");
values.Count().Dump();
	int v = 0;
	foreach (var val in values)
	{
		var tmp = r.Match(val);
		if (tmp.Success == false)
			tmp.Dump();
		var t = (int.Parse(tmp.Groups[1].Value), int.Parse(tmp.Groups[2].Value), tmp.Groups[3].Value[0], tmp.Groups[4].Value);
		
		var count = t.Item4.Count(x=> x == t.Item3);
		if (count >= t.Item1 && count <= t.Item2)
		{
			v++;
			//t.Dump();
			//count.Dump();
		}
	}
	
	v.Dump();
}

// Define other methods, classes and namespaces here
