// See https://aka.ms/new-console-template for more information
Console.WriteLine("请输入枪的名称：");
string gunName = Console.ReadLine();
Console.WriteLine("请输入弹匣容量：");
string capacityInput = Console.ReadLine();
Console.WriteLine("请输入当前子弹数量");
string currentBulletsInput = Console.ReadLine();
Console.WriteLine("请输入剩余子弹数量：");
string remainingBulletsInput = Console.ReadLine();
Console.WriteLine($"枪的名称是：{gunName},弹匣容量是：{capacityInput},当前子弹数量是：" +
    $"{currentBulletsInput}" + "剩余子弹数量是：" + remainingBulletsInput);
string testStr = $"枪的名称是：{gunName},弹匣容量是：{capacityInput},当前子弹数量是：" +
    $"{currentBulletsInput}" + "剩余子弹数量���：" + remainingBulletsInput;
Console.ReadLine();