﻿using System.Linq;
using System.Threading.Tasks;

using NUnit.Framework;

namespace IL2C
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public sealed class TypeSystemsTest
    {
        public static readonly TestCaseInformation[] _EnumTypes = TestUtilities.GetTestCaseInformations<IL2C.TypeSystems.EnumTypes>();
        [Test]
        public static Task EnumTypes([ValueSource(nameof(_EnumTypes))] TestCaseInformation caseInfo) =>
            TestFramework.ExecuteTestAsync(caseInfo);

        public static readonly TestCaseInformation[] _DelegateTypes =
            TestUtilities.GetTestCaseInformations<IL2C.TypeSystems.DelegateTypes>().
            Concat(TestUtilities.GetTestCaseInformations<IL2C.TypeSystems.MulticastDelegateTypes>()).
            Concat(TestUtilities.GetTestCaseInformations<IL2C.TypeSystems.DelegateTypesWithVirtual1>()).
            Concat(TestUtilities.GetTestCaseInformations<IL2C.TypeSystems.DelegateTypesWithVirtual2>()).
           ToArray();
        [Test]
        public static Task DelegateTypes([ValueSource(nameof(_DelegateTypes))] TestCaseInformation caseInfo) =>
            TestFramework.ExecuteTestAsync(caseInfo);

        public static readonly TestCaseInformation[] _ArrayTypes = TestUtilities.GetTestCaseInformations<IL2C.TypeSystems.ArrayTypes>();
        [Test]
        public static Task ArrayTypes([ValueSource(nameof(_ArrayTypes))] TestCaseInformation caseInfo) =>
            TestFramework.ExecuteTestAsync(caseInfo);

        public static readonly TestCaseInformation[] _ExceptionHandling = TestUtilities.GetTestCaseInformations<IL2C.TypeSystems.ExceptionHandling>();
        [Test]
        public static Task ExceptionHandling([ValueSource(nameof(_ExceptionHandling))] TestCaseInformation caseInfo) =>
            TestFramework.ExecuteTestAsync(caseInfo);
    }
}