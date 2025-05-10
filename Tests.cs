using System;
using HREngine.Bots;
using NUnit.Framework;

namespace Hearthbuddy_extension_test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            AiTest test = new AiTest();
            test.MainPath = @"D:\hb\stand\Hearthbuddy\Routines\DefaultRoutine\Silverfish";
            test.TestFilePath = @"Test\Data\对局记录\日期2025-05-05\10-25-39-PRIEST-DRUID\1法力水晶 第2回合 第0步操作.txt";
            test.CardDbPath = "data";
            test.Bot = new Behavior丨狂野丨快攻暗牧();
            test.Test();
        }
    }
}