using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             int getNum(int[] arrNum, int tmp, int minNum, int maxNum, Random ra)
            {
                int n = 0;
                while (n <= arrNum.Length - 1)
                {
                    if (arrNum[n] == tmp) //利用循环判断是否有重复
                    {
                        tmp = ra.Next(minNum, maxNum); //重新随机获取。
                        getNum(arrNum, tmp, minNum, maxNum, ra);//递归:如果取出来的数字和已取得的数字有重复就重新随机获取。
                    }
                    n++;
                }
                return tmp;
            }
            int[] getRandomNum(int num, int minNum, int maxNum)
            {

                Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
                int[] arrNum = new int[num];
                int tmp = 0;
                for (int i = 0; i <= num - 1; i++)
                {
                    tmp = ra.Next(minNum, maxNum); //随机取数
                    arrNum[i] = getNum(arrNum, tmp, minNum, maxNum, ra); //取出值赋到数组中
                }
                return arrNum;
            }
        }
    }
}
