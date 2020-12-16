<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var text = @"";

	var patterns = new[] { "ecl", "pid", "eyr", "hcl", "byr", "iyr", "hgt" }
					.Select(x=> new Regex($@"{x}:\S*\s"));

	Regex.Split(text, @"^\s*$", RegexOptions.Multiline)
	.Select(x => patterns.Count(y => y.IsMatch(x)))
	.Count(x => x == 7)
	.Dump();
	//
	//foreach (var line in Regex.Split(text,@"^\s*$", RegexOptions.Multiline))
	//{
	//	patterns.Count(x=> x.IsMatch(line)).Dump();
	//}
}

// You can define other methods, fields, classes and namespaces here
