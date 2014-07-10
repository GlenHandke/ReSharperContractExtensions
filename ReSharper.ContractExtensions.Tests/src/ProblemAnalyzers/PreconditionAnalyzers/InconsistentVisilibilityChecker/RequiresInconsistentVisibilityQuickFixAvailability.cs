﻿using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Intentions.Test;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;
using ReSharper.ContractExtensions.ProblemAnalyzers.PreconditionAnalyzers;

namespace ReSharper.ContractExtensions.Tests.ProblemAnalyzers.PreconditionAnalyzers
{
    [TestFixture]
    public class RequiresInconsistentVisibilityQuickFixAvailability : QuickFixAvailabilityTestBase<RequiresInconsistentVisibiityHighlighting>
    {
        protected override string RelativeTestDataPath
        {
            get { return @"QuickFixes\PreconditionAnalyzers"; }
        }

        [TestCase("FixEnclosingMemberVisibilityAvailability.cs")]
        [TestCase("FixEnclosingMemberVisibilityUnavailable.cs")]
        [TestCase("FixEnclosingMemberVisibilityUnavailableForInnerType.cs")]
        public void AvailabilityTest(string fileName)
        {
            DoTestFiles(fileName);
        }

    }
}