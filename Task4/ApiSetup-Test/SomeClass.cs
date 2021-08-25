namespace ApiSetupTest
{
    public class SomeClass
    {
        public void Setup()
        {
            var apiObject = new Api();

            apiObject.For(new ObjectA()).SetupObjectA();
            apiObject.For(new ObjectB()).SetupObjectB();
        }
    }
}