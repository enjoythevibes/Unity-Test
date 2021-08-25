namespace AvoidBoxingTest
{
    public class SomeClass
    {
        public void Run()
        {
            var someStruct = new SomeStruct();
            var someStruct2 = new SomeStruct2();
            SomeMethod(someStruct);
            SomeMethod(someStruct2);
        }

        public void SomeMethod<T>(T @interface) where T : ISomeInterface
        {
            @interface.Call();
        }
    }
}