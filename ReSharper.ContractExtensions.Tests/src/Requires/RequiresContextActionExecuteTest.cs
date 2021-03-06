﻿using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using NUnit.Framework;
using ReSharper.ContractExtensions.ContextActions.Requires;

namespace ReSharper.ContractExtensions.Tests.Preconditions
{
    [TestFixture]
    public class RequiresContextActionExecuteForIndexerTest : RequiresContextActionExecuteTestBase<AddRequiresContextAction>
    {
        protected override string RelativeTestDataPath
        {
            get { return "Intentions/ContextActions/Requires/IndexerFixes"; }
        }

        protected override string ExtraPath
        {
            get { return "Requires/IndexerFixes"; }
        }

        [TestCase("GetterAndSetter")]
        [TestCase("OnSetter")]
        [TestCase("SetterOnly")]
        [TestCase("SimpleIndexer")]
        public void TestIndexerExecution(string test)
        {
            DoOneTest(test);
        }
    }

    [TestFixture]
    public class RequiresContextActionExecuteTest : RequiresContextActionExecuteTestBase<AddRequiresContextAction>
    {
        protected override string RelativeTestDataPath
        {
            get { return "Intentions/ContextActions/Requires"; }
        }
        protected override string ExtraPath
        {
            get { return "Requires"; }
        }

        [TestCase("Execution")]

        [TestCase("ExecutionForCrazyName")]

        [TestCase("ExecutionForAbstractMethod")]

        [TestCase("ExecutionOnPropertySetter")]
        [TestCase("ExecutionForInterface")]

        [TestCase("ExecutionWithExistingUsing")]

        [TestCase("ExecutionWithSpecifiedOrder")]
        [TestCase("ExecutionWithSpecifiedOrder2")]
        [TestCase("ExecutionWithSpecifiedOrder3")]
        [TestCase("ExecutionWithSpecifiedOrder4")]
        public void TestSimpleExecution(string testSrc)
        {
            DoOneTest(testSrc);
        }
    }
}