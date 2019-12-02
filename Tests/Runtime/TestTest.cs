
using NUnit.Framework;

public class HpCompTests
{
    //测试被攻击之后伤害数值是否和预期值相等
    [Test]
    public void TakeDamage_BeAttacked_HpEqual()
    {
        //Arrange
        HpComp health = new HpComp();
        health.currentHp = 100;
        //Act
        health.TakeDamage(50);
        //Assert
        Assert.AreEqual(50f, health.currentHp);
    }

    class HpComp
    {
        public int currentHp;

        public void TakeDamage(int value)
        {
            currentHp -= value;
        }
    }
}