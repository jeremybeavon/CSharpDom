using CSharpDom.TestTarget.Classes.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalNestedDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPublicNestedDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicNestedDelegate));
        }
    }
}
