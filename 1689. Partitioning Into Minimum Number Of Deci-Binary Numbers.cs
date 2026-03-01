
//1689. Partitioning Into Minimum Number Of Deci-Binary Numbers

//problem link :
//  https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/description/?envType=daily-question&envId=2026-03-01



// notes 
// the most important step is to cast from char to int
//            number = c - '0';   // 5


public class Solution
{

    public int MinPartitions(string n)
    {
        int max = 0;
        int number = 0;
        foreach (int c in n)
        {

            number = c - '0';   // 5
            if (number > max)
            {
                max = number;
            }


        }

        return max;
    }
}