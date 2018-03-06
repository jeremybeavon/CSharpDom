using Microsoft.CodeAnalysis.CodeFixes;
using System;
using System.Composition.Hosting;
using System.Linq;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    internal static class CodeAnalysisCodeFixProvider
    {
        private static readonly Lazy<(CodeFixProvider provider, ExportCodeFixProviderAttribute attribute)[]> codeFixProviders =
            new Lazy<(CodeFixProvider provider, ExportCodeFixProviderAttribute attribute)[]>(InitializeCodeFixProviders);

        public static CodeFixProvider GetCodeFixProvider(string name)
        {
            return codeFixProviders.Value.FirstOrDefault(provider => provider.attribute.Name == name).provider;
        }

        private static (CodeFixProvider provider, ExportCodeFixProviderAttribute attribute)[] InitializeCodeFixProviders()
        {
            Assembly assembly = Assembly.Load("Microsoft.CodeAnalysis.CSharp.Features");
            ContainerConfiguration configuration = new ContainerConfiguration().WithAssembly(assembly);
            CompositionHost container = configuration.CreateContainer();
            return (from provider in container.GetExports<CodeFixProvider>()
                    let attribute = Attribute.GetCustomAttribute(
                        provider.GetType(),
                        typeof(ExportCodeFixProviderAttribute)) as ExportCodeFixProviderAttribute
                    where attribute != null
                    select (provider, attribute)).ToArray();
        }
    }
}
