namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double[] TestMoney = Store.shopping(9410.50);
         double[] myNum = { 9, 0, 4, 0, 0, 1, 0, 2, 0, 1, 0 };
         Assert.Equal(TestMoney,myNum);
    }
}