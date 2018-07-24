<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if (isset($_GET['num'])) {
        $num = intval($_GET['num']);
        $num1 = 0;
        $num2 = 1;
        $num3 = 0;
        echo "1"." ";
        for ($i =0; $i <= $num -2; $i++){
            $num3 = $num1 + $num2;
            $num1 = $num2;
            $num2 = $num3;
            echo $num3." ";
        }
    }
    ?>
</body>
</html>