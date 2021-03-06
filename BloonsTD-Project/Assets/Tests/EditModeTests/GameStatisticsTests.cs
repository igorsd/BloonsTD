using NUnit.Framework;
using FluentAssertions;
using TMG.BloonsTD.Stats;
using TMG.BloonsTD.TestInfrastructure;

namespace EditModeTests
{
    public class GameStatisticsTests
    {
        [Test]
        public void Test_High_Stats_With_No_Max()
        {
            GameStatistics testGameStatistics = A.GameStatistics.WithRounds(int.MaxValue).WithMoney(int.MaxValue)
                .WithLives(int.MaxValue);

            testGameStatistics.Rounds.Should().Be(int.MaxValue);
            testGameStatistics.Money.Should().Be(int.MaxValue);
            testGameStatistics.Money.Should().Be(int.MaxValue);
        }

        [Test]
        public void Test_Low_Stats_With_No_Max()
        {
            GameStatistics testGameStatistics = A.GameStatistics.WithRounds(int.MinValue).WithMoney(int.MinValue)
                .WithLives(int.MinValue);
            
            testGameStatistics.Rounds.Should().Be(0);
            testGameStatistics.Money.Should().Be(0);
            testGameStatistics.Money.Should().Be(0);
        }

        [Test]
        public void Test_High_Stats_With_Max()
        {
            GameStatistics maxGameStatistics = A.GameStatistics.WithRounds(50).WithMoney(650).WithLives(50);
            GameStatistics testGameStatistics = A.GameStatistics.WithRounds(int.MaxValue).WithMoney(int.MaxValue)
                .WithLives(int.MaxValue).WithMaxStatistics(maxGameStatistics);
            
            testGameStatistics.Rounds.Should().Be(50);
            testGameStatistics.Money.Should().Be(650);
            testGameStatistics.Lives.Should().Be(50);
        }

        [Test]
        public void Test_Low_Stats_With_Max()
        {
            GameStatistics maxGameStatistics = A.GameStatistics.WithRounds(50).WithMoney(650).WithLives(50);
            GameStatistics testGameStatistics = A.GameStatistics.WithRounds(int.MinValue).WithMoney(int.MinValue)
                .WithLives(int.MinValue).WithMaxStatistics(maxGameStatistics);
            
            testGameStatistics.Rounds.Should().Be(0);
            testGameStatistics.Money.Should().Be(0);
            testGameStatistics.Money.Should().Be(0);
        }
    }
}