using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_StaticClasses_NestedAbstractClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
