namespace Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press Enter button to throw darts");
                Console.ReadLine();

                int points = 100;
                int pointsToSubstract = 10;

                Random random = new Random();
                int x = random.Next(-200, 200);
                int y = random.Next(-200, 200);


                ThrowDarts(points, pointsToSubstract, x, y);
            }

        }
        //this method calculates if we hit or miss
        static void ThrowDarts(int points, int pointsToSubstract, int x, int y)
        {
            int newX = x;
            int newY = y;

            if (x < 0)
            {
                newX *= -1;
            }
            if (y < 0)
            {
                newY *= -1;
            }

            //if x,y is less than 10 so we reach R1 and get 100points;
            if (newX <= 10 && newY <= 10 && newX >= -10 && newY >= -10)
            {
                Console.WriteLine($"x = {x}, y = {y}");
                Console.WriteLine($"Congratulation, you get {points} points");
            }
            //if x ory is more than10 and less than100 we reach R2-R10 and get 90-10points;F.E if x/y is 91 - you reach R10 so you get 10points;
            else if (((newX > 10 || newY > 10) && (newX < 100 && newY < 100)) || ((newX < -10 || newY < -10) && (newX > -100 && newY > -100)))
            {
                if (newX > newY)
                {
                    string firstValue = newX.ToString();
                    string secondValue = firstValue.Substring(0, 1);

                    int value = Convert.ToInt32(secondValue);

                    points = points - pointsToSubstract * value;
                }
                //if (newY > newX)
                else
                {
                    string firstValue = newY.ToString();
                    string secondValue = firstValue.Substring(0, 1);

                    int value = Convert.ToInt32(secondValue);

                    points = points - pointsToSubstract * value;
                }
                Console.WriteLine($"x = {x}, y = {y}");
                Console.WriteLine($"Congratulation, you get {points} points");
            }
            else if ((newX > 100 || newY > 100) || (newX < -100 || newY < -100))
            {
                Console.WriteLine($"x = {x}, y = {y}");
                Console.WriteLine("You Miss");
            }
        }
    }
}