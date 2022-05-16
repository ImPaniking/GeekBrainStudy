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
    <div class = "contentWrap">
        <div class="content">
            <div class = "center">

                <h1 id = "info"> Игра : Угадай загадку </h1>

                <div class="box">

                    <?php
                        $score = 0;
                        if (isset($_GET["userAnswer1"]) && isset($_GET["userAnswer2"]) && isset($_GET["userAnswer2"])){
                            $userAnswer = $_GET["userAnswer1"];
                            if ($userAnswer == "сон" || $userAnswer == "сноведение") $score++;

                            $userAnswer = $_GET["userAnswer2"];
                            if ($userAnswer == "морской" || $userAnswer == "укус акулы") $score++;

                            $userAnswer = $_GET["userAnswer3"];
                            if ($userAnswer == "шахматный" || $userAnswer == "мёртвый") $score++;

                            echo "Вы угадали ".$score." закадки";
                        }                        

                    ?>

                    <form method="GET">
                        <p>Что можно увидеть закрытыми глазами ?</p>
                        <input type="text" name = "userAnswer1">

                        <p>Какой болезнью не болеют на суше ?</p>
                        <input type="text" name = "userAnswer2">

                        <p>Какой конь не есть овса ?</p>
                        <input type="text" name = "userAnswer3">

                        <br>
                        <input type="submit" value="Ответить" name="">
                    </form>

                </div>

            </div>
        </div>
    </div>
        
        
        


    <div class="footer">Copyright &copy; Penschii Artiom&trade;<br>Copyright &copy;<a href="https://geekbrains.ru"> GeekBrains &trade; <?php echo date("Y");?></div>
    
</body>
</html>