namespace Quiz2;


class Program
{

    static void Main()
    {

        string[] questions = new string[]
        {
            "Bakının paytaxtı haradır?",
            "C# nedir?",
            "Bunlardan hansı giriş qurğusudur?",
            "Hansı front-end üçün istifade olunur",
            "2*2(4/2) ?",
            "Hansı 3. grup ixtisas fenni deyil",
            "Hansı benzin növü deyil",
            "'Heyat' sözünde neçe samit var",
            "Rolex nedir",
            "Hansı top ile oynamiyan idmandır"
        };
        string[] correctAnswers = new string[]
        {
            "Baku",
            "Programming leanguage",
            "Mikrofon",
            "React",
            "8",
            "Informatika",
            "94",
            "3",
            "Saat",
            "Uzguculuk"
        };

        string[] answers = new string[]
        {
            "Baku",
            "Yevlax",
            "Bileceri",
            "Programming leanguage",
            "Masin marka",
            "Exel",
            "Mikrofon",
            "Monitor",
            "Proyektor",
            "React",
            "C++",
            "Python",
            "8",
            "4",
            "0",
            "Informatika",
            "Tarix",
            "Cografiya",
            "94",
            "98",
            "92",
            "3",
            "2",
            "0",
            "Saat",
            "Qabyuyan",
            "Fen",
            "Basketbol",
            "Uzguculuk",
            "Futbol"
        };

        int coin = 0;

        bool CheckQuestion(int number, int answer)
        {
            if (correctAnswers[number] == answers[answer])
            {
                coin += 10;
                return true;
            }

            coin = coin == 0 ? 0 : coin - 10;
            return false;
        }

        void BringQuestions()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            Random random = new Random();
            int number = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                A = random.Next(0, 3);
                do
                {
                    B = random.Next(0, 3);
                } while (A == B);

                do
                {
                    C = random.Next(0, 3);
                } while (A == C || B == C);

                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine(questions[i]);
                Console.WriteLine($"A: {answers[i * 3 + A]} ");
                Console.WriteLine($"B: {answers[i * 3 + B]} ");
                Console.WriteLine($"C: {answers[i * 3 + C]} ");
                ConsoleKeyInfo op = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine(questions[i]);
                if (op.Key == ConsoleKey.A)
                {
                    if (CheckQuestion(number, number * 3 + A))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"A: {answers[i * 3 + A]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"A: {answers[i * 3 + A]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine($"B: {answers[i * 3 + B]} ");
                    Console.WriteLine($"C: {answers[i * 3 + C]} ");
                    Thread.Sleep(3000);
                }
                else if (op.Key == ConsoleKey.B)
                {
                    Console.WriteLine($"A: {answers[i * 3 + A]} ");

                    if (CheckQuestion(number, number * 3 + B))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"B: {answers[i * 3 + B]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"B: {answers[i * 3 + B]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine($"C: {answers[i * 3 + C]} ");
                    Thread.Sleep(3000);
                }
                else if (op.Key == ConsoleKey.C)
                {
                    Console.WriteLine($"A: {answers[i * 3 + A]} ");
                    Console.WriteLine($"B: {answers[i * 3 + B]} ");

                    if (CheckQuestion(number, number * 3 + C))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"C: {answers[i * 3 + C]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"C: {answers[i * 3 + C]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Thread.Sleep(3000);
                }
            }
            Console.Clear();
            Console.WriteLine($"Your score {coin}");

        }

        while (true)
        {
            Console.WriteLine("Welcome to quiz!");
            Console.WriteLine("Press enter to start");
            Console.WriteLine("There are 10 questions for you");
            ConsoleKeyInfo c1 = Console.ReadKey();

            if (c1.Key == ConsoleKey.Enter)
            {
                BringQuestions();
            }
        }
    }
}

