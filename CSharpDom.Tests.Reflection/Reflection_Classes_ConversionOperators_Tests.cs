using CSharpDom.TestTarget.Classes.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestClassWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithImplicitConversionOperatorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestClassWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestClassWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitConversionOperatorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitConversionOperator));
        }
    }
}
