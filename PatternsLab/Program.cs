namespace PatternsLab;

public class VideoConferenceManager
{
    private static VideoConferenceManager instance;
    
    // Приклад змінних для управління підключенням та передачею даних
    private bool isConnected;
    private bool isDataTransmitting;
    
    // Приватний конструктор, щоб унеможливити створення екземплярів класу ззовні
    private VideoConferenceManager() { }

    // Метод для отримання єдиного екземпляру класу
    public static VideoConferenceManager GetInstance()
    {
        if (instance != null) return instance;
        instance = new VideoConferenceManager();
        return instance;
    }

    // Приклад методів для керування відеоконференцією
    public void Connect()
    {
        isConnected = true;
        Console.WriteLine("Connected to the video conference.");
    }

    public void Disconnect()
    {
        isConnected = false;
        Console.WriteLine("Disconnected from the video conference.");
    }

    public void StartDataTransmission()
    {
        if (isConnected)
        {
            isDataTransmitting = true;
            Console.WriteLine("Data transmission started.");
        }
        else
        {
            Console.WriteLine("Cannot start data transmission. Not connected to the conference.");
        }
    }

    public void StopDataTransmission()
    {
        isDataTransmitting = false;
        Console.WriteLine("Data transmission stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Отримання єдиного екземпляру класу VideoConferenceManager
        VideoConferenceManager manager1 = VideoConferenceManager.GetInstance();
        VideoConferenceManager manager2 = VideoConferenceManager.GetInstance();

        // Перевірка, що обидва manager1 та manager2 вказують на один і той же об'єкт
        if (manager1 == manager2)
        {
            Console.WriteLine("manager1 та manager2 вказують на один і той же об'єкт.");
        }

        // Приклад використання методів керування відеоконференцією
        manager1.Connect();
        manager1.StartDataTransmission();
        manager2.StopDataTransmission();
        manager1.Disconnect();
    }
}