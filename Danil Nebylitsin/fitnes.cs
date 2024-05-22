using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

class Exercise
{
    public string Name { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public Exercise(string name, int sets, int reps)
    {
        Name = name;
        Sets = sets;
        Reps = reps;
    }
}

class Trainer
{
    public string Name { get; set; }
    public Trainer(string name)
    {
        Name = name;
    }
}

class Equipment
{
    public string Name { get; set; }
    public Equipment(string name)
    {
        Name = name;
    }
}

class WorkoutProgram
{
    public string Name { get; set; }
    public List<Exercise> Exercises { get; }

    public WorkoutProgram(string name)
    {
        Name = name;
        Exercises = new List<Exercise>();
    }
    public void AddExercise(string name, int sets, int reps)
    {
        Exercises.Add(new Exercise(name, sets, reps));
    }
    public void AddCardioExercise(string name, int durationMinutes)
    {
        Exercises.Add(new Exercise(name, 1, durationMinutes));
    }
}

class WorkoutLog
{
    public List<Exercise> Exercises { get; }
    public Trainer SelectedTrainer { get; set; }
    public Equipment SelectedEquipment { get; set; }
    public WorkoutProgram SelectedProgram { get; set; }
    public WorkoutLog()
    {
        Exercises = new List<Exercise>();
    }
    public void AddExercise(string name, int sets, int reps)
    {
        Exercises.Add(new Exercise(name, sets, reps));
    }
    public void AddCardioExercise(string name, int durationMinutes)
    {
        Exercises.Add(new Exercise(name, 1, durationMinutes));
    }
    public void DisplayWorkout()
    {
        Console.WriteLine("Ваш журнал тренировок:");
        foreach (var exercise in Exercises)
        {
            Console.WriteLine($"Упражнение: {exercise.Name}, Подходы: {exercise.Sets}, Повторения: {exercise.Reps}");
        }
        Console.WriteLine($"Ваш тренер: {SelectedTrainer.Name}");
        Console.WriteLine($"Ваш тренажер: {SelectedEquipment.Name}");
        Console.WriteLine($"Выбранная программа тренировок: {SelectedProgram.Name}");
    }
}

class FitnesApp
{
    static void Man()
    {
        Console.WriteLine("Добро пожаловать в приложение ФитнесClub!");
        Console.WriteLine("Начните тренировку сегодня.");

        WorkoutLog workoutLog = new WorkoutLog();

        Console.WriteLine("\nВыберите программу тренировок:");
        Console.WriteLine("1. Программа для начинающих");
        Console.WriteLine("2. Программа для опытных");
        Console.WriteLine("3. Программа для укрепления мышц");
        Console.WriteLine("4. Индивидуальная программа");
        int programChoice;
        while (!int.TryParse(Console.ReadLine(), out programChoice) || (programChoice < 1 || programChoice > 4))
        {
            Console.WriteLine("Некорректный выбор программы. Пожалуйста, выберите от 1 до 4:");
        }
        WorkoutProgram[] programs = {
            new WorkoutProgram("Программа для начинающих"),
            new WorkoutProgram("Программа для опытных"),
            new WorkoutProgram("Программа для укрепления мышц"),
            new WorkoutProgram("Индивидуальная программа")
        };
        switch (programChoice)
        {
            case 1:
                workoutLog.SelectedProgram = programs[0];
                break;
            case 2:
                workoutLog.SelectedProgram = programs[1];
                break;
            case 3:
                workoutLog.SelectedProgram = programs[2];
                break;
            case 4:
                workoutLog.SelectedProgram = programs[3];
                Console.WriteLine("\nВведите вашу индивидуальную программу тренировок:");
                Console.WriteLine("Введите 'готово', когда закончите.");
                string exerciseName;
                int sets, reps;
                while (true)
                {
                    Console.Write("Введите название упражнения: ");
                    exerciseName = Console.ReadLine();
                    if (exerciseName.ToLower() == "готово")
                    {
                        break;
                    }
                    Console.Write("Введите количество подходов: ");
                    while (!int.TryParse(Console.ReadLine(), out sets) || sets <= 0)
                    {
                        Console.WriteLine("Некорректное количество подходов. Пожалуйста, введите положительное целое число.");
                    }
                    Console.Write("Введите количество повторений: ");
                    while (!int.TryParse(Console.ReadLine(), out reps) || reps <= 0)
                    {
                        Console.WriteLine("Некорректное количество повторений. Пожалуйста, введите положительное целое число.");
                    }
                    workoutLog.SelectedProgram.AddExercise(exerciseName, sets, reps);
                    workoutLog.AddExercise(exerciseName, sets, reps);
                }
                break;
            default:
                break;
        }
        Console.WriteLine("\nВыберите тренера:");
        Console.WriteLine("1. Тренер Александр Викторович");
        Console.WriteLine("2. Тренер Андрей Михайлович");
        Console.WriteLine("3. Тренер Екатерина Павловна");
        Console.WriteLine("4. Тренер Иван Сергеевич");
        Console.WriteLine("5. Тренер Ольга Николаевна");
        int trainerChoice;
        while (!int.TryParse(Console.ReadLine(), out trainerChoice) || (trainerChoice < 1 || trainerChoice > 5))
        {
            Console.WriteLine("Некорректный выбор тренера. Пожалуйста, выберите от 1 до 5:");
        }
        string[] trainerNames = { "Тренер Александр Викторович", "Тренер Андрей Михайлович", "Тренер Екатерина Павловна", "Тренер Иван Сергеевич", "Тренер Ольга Николаевна" };
        workoutLog.SelectedTrainer = new Trainer(trainerNames[trainerChoice - 1]);
        Console.WriteLine("\nВыберите тренажер:");
        Console.WriteLine("1. Тренажер Турник");
        Console.WriteLine("2. Тренажер Беговая дорожка");
        Console.WriteLine("3. Тренажер Велотренажер");
        Console.WriteLine("4. Тренажер Гантели");
        Console.WriteLine("5. Тренажер Шведская стенка");
        int equipmentChoice;
        while (!int.TryParse(Console.ReadLine(), out equipmentChoice) || (equipmentChoice < 1 || equipmentChoice > 5))
        {
            Console.WriteLine("Некорректный выбор тренажера. Пожалуйста, выберите от 1 до 5:");
        }
        string[] equipmentNames = { "Тренажер Турник", "Тренажер Беговая дорожка", "Тренажер Велотренажер", "Тренажер Гантели", "Тренажер Шведская стенка" };
        workoutLog.SelectedEquipment = new Equipment(equipmentNames[equipmentChoice - 1]);
        workoutLog.DisplayWorkout();
        Console.WriteLine("\nНачать тренировку? (да/нет)");
        string startWorkoutChoice = Console.ReadLine();
        if (startWorkoutChoice.ToLower() == "да")
        {
            Console.WriteLine("\nТренировка начата!");
        }
        else
        {
            Console.WriteLine("\nЖдем вас на следующей тренировке!");
        }
    }
}
