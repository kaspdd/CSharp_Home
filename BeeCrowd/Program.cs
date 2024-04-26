double raio, area, pi;
        pi = 3.14159;
        raio = double.Parse(Console.ReadLine());
        area = pi * Math.Pow(raio, 2);
        Console.WriteLine($"A={area:f4}");

