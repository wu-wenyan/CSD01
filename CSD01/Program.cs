int i, num, sum = 0;
try
{
    for (i = 1; i <= 5; i++)
    {
        bool test = true;
        while (test)
        {

            Console.Write("起輸入第" + i + "個1-100的整數(均不含1、100)>");
            num = Convert.ToInt16(Console.ReadLine());
            if ((num > 1) && (num < 100))
            {
                sum += num;
                test = false;
            }
            else
            {
                Console.WriteLine("輸入數字必須在1-100之間，請重新輸入");
            }
            

        }
    }
    Console.WriteLine("你輸入的5個整數合是" + sum + "\n你輸入的5個整數其平均是" + sum / 5);
    Console.ReadLine();

}
catch (Exception)
{
    Console.WriteLine("輸入錯誤，請重新執行");
    Console.ReadLine();
}