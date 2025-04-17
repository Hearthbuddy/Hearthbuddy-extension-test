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
            test.TestFilePath = @"Test\Data\对局记录\日期2025-04-05\18-04-37-SHAMAN-PRIEST\7法力水晶 第7回合 第0步操作.txt";
            test.CardDbPath = "data";
            test.Bot = new Behavior丨通用丨不设惩罚();
            test.Test();
        }
    }
}