using FsCheck;
using FsCheck.Xunit;
using Xunit;

namespace PropertyBasedTesting.Test
{
    public class xUnitPBT
    {
        //PropertyTesting with xUnit using FsCheck


        [Property]
        public Property Test_x_Times_2_Equals_x_Plus_x(int x)
        {
            return (x * 2 == Add(x, x)).ToProperty();
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

        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}