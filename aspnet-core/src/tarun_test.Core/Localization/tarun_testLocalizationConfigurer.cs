using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace tarun_test.Localization
{
    public static class tarun_testLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(tarun_testConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(tarun_testLocalizationConfigurer).GetAssembly(),
                        "tarun_test.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
