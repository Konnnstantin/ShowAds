using ShowAds;
{
    User user = new User(false);
    User user1 = new User(false);
    User user2 = new User(true);
    List<User> users = new List<User> { user, user1, user2 };

    foreach (var UserList in users)
    {
        if (UserList.IsPremium == false)
        {
            ShowAds();
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($" Приветствуем вас {UserList.Name}, под логином {UserList.Login} \n ");
    }
}
static void ShowAds()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine(" Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine(" Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
}
