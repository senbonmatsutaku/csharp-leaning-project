using chapter_13.domain.service;
using chapter_13.domain.service.student667;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_13_test.domain.service.student667
{
    [TestClass]
    public class Task667Test
    {
        [TestMethod]
        public void すべての文字列が正常となる()
        {
            ITask task = new Task667();
            Assert.IsTrue( task.Task1("すべての文字列"));
        }
        [TestMethod]
        public void 最初の１文字はＡで２文字目は数字で３文字目は数字か無しが正常となる()
        {
            ITask task = new Task667();
            Assert.IsTrue(task.Task1("A10"));
        }
        [TestMethod]
        public void 最初の１文字はＵで２文字目から４文字目は英大文字が正常となる()
        {
            ITask task = new Task667();
            Assert.IsTrue(task.Task1("USAGI"));
        }
    }
}
