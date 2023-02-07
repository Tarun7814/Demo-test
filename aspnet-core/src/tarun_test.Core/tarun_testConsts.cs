using tarun_test.Debugging;

namespace tarun_test
{
    public class tarun_testConsts
    {
        public const string LocalizationSourceName = "tarun_test";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5b3be5af4c804de5ba2356fd7d025464";
    }
}
