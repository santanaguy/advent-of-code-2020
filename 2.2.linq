<Query Kind="Program" />

void Main()
{
	var r = new Regex(@"(\d*)-(\d*) (.): (.*)");
	var values = File.ReadAllLines(@"C:\Users\Admin\Documents\Projetos\advent-of-code-2020\2.txt");
	
	values
	.Select(x=> r.Match(x))
	.Select(x=> (int.Parse(x.Groups[1].Value), int.Parse(x.Groups[2].Value), x.Groups[3].Value[0], x.Groups[4].Value))
	.Count(t=> (t.Item4[t.Item1 - 1] == t.Item3) ^ (t.Item4[t.Item2 - 1] == t.Item3))
	.Dump();
}

// Define other methods, classes and namespaces here
