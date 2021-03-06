﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFCore.Jet.Integration.Test.Model30
{
    public abstract class Test : TestBase<Context>
    {
        [TestMethod]
        public void Run()
        {
            var answers = Context.Answers.Where(x => x.Question.QuestionId == 12).ToList();
        }
    }
}
