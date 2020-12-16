var numbers = File.ReadAllLines("./1.txt")
                .Select(x=> Convert.ToInt32(x))
                .ToList();

for (int i = 0; i < numbers.Count-1; i++)
    for (int j = i; j < numbers.Count-1; j++)
        for (int k = j; k < numbers.Count-1; k++)
            if (numbers[i] + numbers[j] + numbers[k] == 2020)
                {
                    Console.WriteLine(numbers[i] * numbers[j] * numbers[k]);
                    return;
                }