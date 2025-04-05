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
            test.MainPath = @"D:\hb\r\Hearthbuddy\Routines\DefaultRoutine\Silverfish";
            test.TestFilePath = @"Test\Data\对局记录\日期2025-04-05\16-16-14-MAGE-PRIEST\3法力水晶 第6回合 第4步操作.txt";
            test.CardDbPath = "data";
            test.Bot = new Behavior丨狂野丨奥秘法();
            test.Test();
        }
    }
}