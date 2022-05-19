# Методы

_Есть основные типы функций:_

- **`По типо возвращения`**

  - **`Ничего не возвращает`** - _Функция которая не возвращает значения плсде выполнения_

    ```csharp
    void Metod(){}
    ```

  - **`Что то возвращает`** - _Функция которая возвращает значения плсде выполнения_

    ```csharp
    string Metod(){
    return text;}
    ```

    > где `sting` - это тип возвращаемой переменной, `Metod` - название метода,`()` - место для описи аргументов,`{}` - тело метода `return text` - text будет выводится из метода.

- **`По типо аргументов`**

  - **`Без аргументов`** - _В функцию не вводятся аргументы_

    ```csharp
    void Metod(){
    Console.WriteLine("Hello World");}
    ```

  - **`С аргументами`** - _В функции есть аргументы которые можно ввести_

    > Мовитон иметь максимум 5 аргументов в функции. Встроенные методы могут достигать и 16 аргументов, но как правило - столько аргументов не нужно.

    ```Csharp
    void Metod(int a, int b){
    Console.WriteLine($"{a}+{b}={a+b}");}
    ```

    ```Csharp
    void Metod(int a, int b){
    Console.WriteLine($"{a}+{b}={a+b}");}
    Metod(5,6); /* или */ Metod(a:5,b:6);
    ```

# Цикл со счётчиком for

_Более универцальный цикл, с счётчиком. Замена While со счётчиком_

```Csharp
for (int i=0; i<5;i++){}
```

> Где `int i = 0` - _задаётся переменная счётчика и присваивается начальная позиция._

> Где `i < 5` - _Указывает сколько раз проводит цикл_

> Где `i++` - _Увеличение счётчика_

**`ВАЖНО! Циклы в Циклах использовать можно и регулряно даже НУЖНО! не стоит этого боятся.`** 