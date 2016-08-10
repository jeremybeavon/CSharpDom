using CSharpDom.TestTarget.AbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_AbstractClasses_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalConstructorUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateConstructorUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedConstructorUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicConstructorUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicConstructor));
        }
    }
}
