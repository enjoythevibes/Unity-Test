# Unity-Test

### Задание 1

Необходимо разработать элементарную игру-кликер. В игре присутствует один UI-экран,
состоящий из кнопки и текстового поля. Пользователь кликает по кнопке. В текстовом поле
выводится кол-во кликов.

### Задание 2
Необходимо разработать Unity-проект. Приложение должно спаунить 3D-кубы, которые затем
перемещаются с определенной скоростью на определенное расстояние. После прохождения
указанного расстояния, куб исчезает. Время, через которое создается очередной куб, скорость
и расстояние должны вводиться пользователем в текстовых полях.

### Задание 3
Ниже приведен код, в котором присутствует проблема boxing'а. Необходимо любым известным
Вам способом исправить эту проблему.

```
interface ISomeInterface
{
 void Call();
}
struct SomeStruct : ISomeInterface
{
 public void Call()
 { }
}
class SomeClass
{
 public void Run()
 {
 var someStruct = new SomeStruct();
 SomeMethod(someStruct);
 }
 public void SomeMethod(ISomeInterface @interface)
 {
 @interface.Call();
 }
}
```

### Задание 4
Ниже представлена часть кода, реализующая абстрактную настройку экземпляров классов
ObjectA и ObjectB неким API. Необходимо реализовать два метода: SetupObjectA и
SetupObjectB, используя Generic-возможности языка и Extension-методы таким образом,
чтобы метод SetupObjectA был доступен только при передаче в метод For аргумента типа
ObjectA, а метод SetupObjectB при передаче аргумента типа ObjectB.

```
public struct ApiSetup<T>
{ }
class Api
{
 public ApiSetup<T> For<T>(T obj)
 {
 return new ApiSetup<T>();
 }
}
interface ISomeInterfaceA
{ }
interface ISomeInterfaceB
{ }
public class ObjectA : ISomeInterfaceA
{ }
public class ObjectB : ISomeInterfaceB
{ }
class SomeClass
{
 public void Setup()
 {
 Api apiObject = new Api();

 apiObject.For(new ObjectA()).SetupObjectA();
 apiObject.For(new ObjectB()).SetupObjectB();
 }
}
```


