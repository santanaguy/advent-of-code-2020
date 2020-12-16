<Query Kind="Program" />

void Main()
{
	var m = File.ReadAllLines(@"C:\Users\Admin\Documents\Projetos\advent-of-code-2020\3.1.txt");
	
	new[] { (1, 1), (1, 3), (1, 5), ( 1, 7), ( 2, 1) }
	.Select(x=> Enumerable.Range(0,m.Length)
				.Select((k, i) => (k*x.Item1, i * x.Item2))
				.Where(x=> x.Item1 < m.Length)
				.LongCount(x => m[x.Item1][x.Item2 % 31] == '#'))
	.Aggregate(1L, (a, b) => a * b).Dump();
	//.Select((k, i) => (k, i * x.First.Item2))
	//				.LongCount(x => m[x.k][x.Item2 % 31] == '#')
	//		)
	
	
	
	//toMatrix(m);
}

void toMatrix(List<string> m)
{
	bool[,] matrix = new bool[m.Count, m[0].Length];

	for (int i = 0; i < m.Count; i++)
		for (int j = 0; j < m[i].Length; j++)
			matrix[i, j] = m[i][j] == '#';
	
	matrix.Dump();
}

// You can define other methods, fields, classes and namespaces here
