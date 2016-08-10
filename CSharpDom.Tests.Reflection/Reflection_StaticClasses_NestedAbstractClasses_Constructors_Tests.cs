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
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
