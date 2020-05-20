using System;

namespace JumpingClouds
{
    public class JumpingClouds
    {
        public int JumpingOnClouds(string cloud)
        {
            var c_temp = cloud.Split(' ');
            var clouds = Array.ConvertAll(c_temp, int.Parse);
            var position = 0;
            var jumpCount = 0;

            while (true)
            {
                if (position + 2 <= clouds.Length - 1 && clouds[position + 2] == 0)
                    position = position + 2;
                else
                    position++;

                jumpCount++;
                if (position == clouds.Length - 1)
                    break;
            }
            return jumpCount;
        }
    }
}