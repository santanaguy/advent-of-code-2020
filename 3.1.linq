<Query Kind="Program" />

void Main()
{
	var m = File.ReadAllLines(@"C:\Users\Admin\Documents\Projetos\advent-of-code-2020\3.1.txt");
			
	Enumerable.Range(0,m.Length)
	.Count(i => m[i][(i*3) % 31] == '#')
	.Dump();
	
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
