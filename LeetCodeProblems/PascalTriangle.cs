using System.Collections.Generic;

public class PascalTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> pascalTriangle = new List<IList<int>>(numRows);
        for (int i = 0; i < numRows; i++)
        {
            pascalTriangle.Add(new List<int>(i + 1));
            for (int j = 0; j < i + 1; j++)
            {
                if (i < 2 || j == 0 || j == i)
                {
                    pascalTriangle[i].Add(1);
                }
                else
                {
                    int val = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
                    pascalTriangle[i].Add(val);
                }
            }
        }
        return pascalTriangle;
    }
}