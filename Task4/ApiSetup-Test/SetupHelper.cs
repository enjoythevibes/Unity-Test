namespace ApiSetupTest
{
    public static class ApiSetupHelper
    {
        public static ApiSetup<ObjectA> SetupObjectA(this ApiSetup<ObjectA> obj)
        {
            return default;
        }
        public static ApiSetup<ObjectB> SetupObjectB(this ApiSetup<ObjectB> obj)
        {
            return default;
        }
    }
}