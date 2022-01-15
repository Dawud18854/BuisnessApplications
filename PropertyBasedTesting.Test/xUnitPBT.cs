using FsCheck;
using FsCheck.Xunit;
using System;
using Xunit;
 
 namespace PropertyBasedTesting.Test
{
    public class xUnitPBT
    {
        //PropertyTesting with xUnit using FsCheck (Wichtig: NugetPackages müssen installiert sein


       [Property]
       public Property Test_x_Times_2_Equals_x_Plus_x(int x)
       {
          return (x* 2 == Add(x, x)).ToProperty();
       }

        [Property]
        public Property Test_x_Plus_1_Plus_1_Equals_x_Plus_2(int x)
        {
           return (Add(1, Add(1, x)) == Add(x, 2)).ToProperty();
        }

        [Property]
        public Property Test_Adding_Order_Doenst_Matter(int x, int y)
        {
           return (Add(x, y) == Add(y, x)).ToProperty();
        }

        [Property]
        public Property Test_Mulitply_And_Divide_By_Same_Number(int x, int y)
        {
           Func<bool> properties = () => Divide(x * y, y) == x;
           //Insted of using a if statement Func provides a useful method
           return properties.When(y != 0);
        }

        public int Divide(int x, int y)
        {
           return x / y;
        }

        public int Add(int x, int y)
        {
           return x + y;
        }
     }
 }