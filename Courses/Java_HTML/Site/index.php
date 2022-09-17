<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="style.css">
    <title>Prnschii Artiom Site Test</title>
</head>

<body>
    <div class="content">

        <?php
            include "meniu.php"
        ?>

        <h1>Тестовый сайт для ознакомления с HTML и CSS</h1>

        <div class="center">
            <img src="img/MyPhoto.png" alt="Я собственной персоной">

            <div class="box_text">
                <p><b>Добрый день</b>. Меня зовут <i>Артём Пенский</i>. Из города Кишинёв ( Молдова )</p>
                <p> Я совсем недавно начал программировать, однако уже написал свой первый сайт.</p>

                <p>В этом мне помог IT-портал <a href="https://geekbrains.ru">GeekBrains</a></p>

                <div class="image">
                    <table>
                        <tr>
                            <th colspan="5">На этом сайте вы сможете сыграть в несколько игр, которые я написал,<br> а
                                так-же найти полезные инструменты:</th>
                        </tr>
                        <tr>
                            <th><a href="puzzle.php" target="_blank"><img src="img/Games.png" alt="Games"></a></th>
                            <th><a href="#" target="_blank"><img src="img/Util.png" alt="Util"></a></th>
                            <th><a href="#" target="_blank"><img src="img/Mat.png" alt="Matimatica"></a></th>
                            <th><a href="#" target="_blank"><img src="img/Info.png" alt="Informatica"></a></th>
                            <th><a href="#" target="_blank"><img src="img/CV.png" alt="About me"></a></th>
                        </tr>
                        <tr>
                            <td><a href="puzzle.php">Игры</a></td>
                            <td><a href="#">Утилиты</a></td>
                            <td><a href="#">Математика</a></td>
                            <td><a href="#">Информатика</a></td>
                            <td><a href="#">Об о мнe</a></td>
                        </tr>
                    </table>
                </div>
            </div>

        </div>
    </div>

    <div class="footer">Copyright &copy; Penschii Artiom&trade;<br>Copyright &copy;<a href="https://geekbrains.ru">
            GeekBrains &trade; <?php echo date("Y");?></div>

</body>

</html>